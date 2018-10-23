//go:generate protoc -I ../coms --go_out=plugins=grpc:../coms ../coms/coms.proto

package main

import (
	"context"
	"encoding/gob"
	"flag"
	"io"
	"log"
	"net"
	"os"
	"strings"
	"time"

	mud "github.com/dearing/mud"
	"github.com/google/uuid"
	"google.golang.org/grpc"
	"google.golang.org/grpc/codes"
	"google.golang.org/grpc/credentials"
	"google.golang.org/grpc/reflection"
	"google.golang.org/grpc/status"
)

const (
	port = ":50051"
)

var (
	version = "1.5"
	commit  = ""
	addr    = flag.String("addr", ":50051", "MUD server address")
	crt     = flag.String("crt", "./misc/localhost.crt", "MUD server cert")
	key     = flag.String("key", "./misc/localhost.key", "MUD server cert key")
)

type server struct{}

var sessions []*session

type session struct {
	token  string
	player *mud.Player
}

var players []*mud.Player

func save(filename string) (err error) {
	file, err := os.Create(filename)
	defer file.Close()
	if err == nil {
		encoder := gob.NewEncoder(file)
		encoder.Encode(players)
	}
	return
}

func load(filename string) (err error) {
	file, err := os.Open(filename)
	defer file.Close()
	if err == nil {
		decoder := gob.NewDecoder(file)
		err = decoder.Decode(&players)
	}
	return
}

func (s *server) Login(context context.Context, request *mud.LoginRequest) (token *mud.Token, err error) {

	uuid := uuid.New()

	if request.Username == "admin" && request.Password == "password" {
		token = &mud.Token{
			Uuid:    uuid.String(),
			Expires: time.Now().Add(time.Duration(20) * time.Hour).String(),
		}
		sessions = append(sessions, &session{
			token:  token.Uuid,
			player: players[0],
		})
		players[0].Logins++
		save("./data/players.gob")

	} else {
		err = status.Errorf(codes.Unauthenticated, "Bad user login.")
	}

	return
}

func (s *server) Chat(stream mud.Game_ChatServer) (err error) {
	for {
		in, err := stream.Recv()
		if err == io.EOF {
			return nil
		}
		if err != nil {
			return err
		}

		log.Printf("CLIENT: %s", in.Message)

		if err := stream.Send(&mud.Message{Message: in.Message}); err != nil {
			return err
		}
	}
}

func (s *server) Queue(stream mud.Game_QueueServer) (err error) {
	for {
		in, err := stream.Recv()
		if err == io.EOF {
			return nil
		}
		if err != nil {
			return err
		}

		log.Printf("CLIENT: %v", in)

		switch in.Action {
		case mud.Action_SAY:
			log.Printf(`%s says, '%s'`, players[0].Name, strings.Join(in.Argument, " "))
			break
		case mud.Action_EMOTE:
			log.Printf(`%s %s`, players[0].Name, strings.Join(in.Argument, " "))
			break
		case mud.Action_LOOK:
			log.Printf(`%s looks around.`, players[0].Name)
			break
		}

		if err := stream.Send(players[0]); err != nil {
			return err
		}
	}
}

func main() {

	log.Printf("MUD v:%s c:%s", version, commit)
	flag.Parse()

	// players = append(players, &mud.Player{
	// 	Uuid:        "0000-0000-0000-000",
	// 	Username:    "admin",
	// 	Name:        "Administrator",
	// 	Description: "Hard coded Admin of the Game.",
	// })

	err := load("./data/players.gob")
	if err != nil {
		log.Fatalf("Error loading players.gob: %v", err)
	}

	log.Printf("Players loaded.\n %+v", players)

	creds, err := credentials.NewServerTLSFromFile(*crt, *key)
	if err != nil {
		log.Fatalf("could not load TLS keys: %s", err)
	}

	lis, err := net.Listen("tcp", port)
	if err != nil {
		log.Fatalf("failed to listen: %v", err)
	}
	s := grpc.NewServer(grpc.Creds(creds),
		grpc.StreamInterceptor(streamInterceptor),
		grpc.UnaryInterceptor(unaryInterceptor),
	)
	mud.RegisterGameServer(s, &server{})
	// Register reflection service on gRPC server.
	reflection.Register(s)
	if err := s.Serve(lis); err != nil {
		log.Fatalf("failed to serve: %v", err)
	}

}
