//go:generate protoc -I ../coms --go_out=plugins=grpc:../coms ../coms/coms.proto

package main

import (
	"flag"
	"io"
	"log"
	"net"

	mud "github.com/dearing/mud"
	"google.golang.org/grpc"
	"google.golang.org/grpc/credentials"
	"google.golang.org/grpc/reflection"
)

const (
	port = ":50051"
)

var (
	version = "1.3"
	commit  = ""
	addr    = flag.String("addr", ":50051", "MUD server address")
	crt     = flag.String("crt", "./misc/server.crt", "MUD server cert")
	key     = flag.String("key", "./misc/server.key", "MUD server cert key")
)

type server struct{}

func (s *server) Echo(stream mud.Messaging_EchoServer) (err error) {
	for {
		in, err := stream.Recv()
		if err == io.EOF {
			return nil
		}
		if err != nil {
			return err
		}

		log.Printf("CLIENT: %s", in.Message)

		if err := stream.Send(&mud.MessageReply{Message: in.Message}); err != nil {
			return err
		}
	}
}

func main() {

	log.Printf("MUD v:%s c:%s", version, commit)
	flag.Parse()

	creds, err := credentials.NewServerTLSFromFile(*crt, *key)
	if err != nil {
		log.Fatalf("could not load TLS keys: %s", err)
	}

	lis, err := net.Listen("tcp", port)
	if err != nil {
		log.Fatalf("failed to listen: %v", err)
	}
	s := grpc.NewServer(grpc.Creds(creds))
	mud.RegisterMessagingServer(s, &server{})
	// Register reflection service on gRPC server.
	reflection.Register(s)
	if err := s.Serve(lis); err != nil {
		log.Fatalf("failed to serve: %v", err)
	}
}
