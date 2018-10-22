//go:generate protoc -I ../coms --go_out=plugins=grpc:../coms ../coms/coms.proto

package main

import (
	"io"
	"log"
	"net"

	mud "github.com/dearing/mud"
	"google.golang.org/grpc"
	"google.golang.org/grpc/reflection"
)

const (
	port = ":50051"
)

var version = "1.1"
var commit = ""

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

	lis, err := net.Listen("tcp", port)
	if err != nil {
		log.Fatalf("failed to listen: %v", err)
	}
	s := grpc.NewServer()
	mud.RegisterMessagingServer(s, &server{})
	// Register reflection service on gRPC server.
	reflection.Register(s)
	if err := s.Serve(lis); err != nil {
		log.Fatalf("failed to serve: %v", err)
	}
}
