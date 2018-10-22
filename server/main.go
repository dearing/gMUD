//go:generate protoc -I ../coms --go_out=plugins=grpc:../coms ../coms/coms.proto

package main

import (
	"log"
	"net"

	rpc "github.com/dearing/mud"
	"golang.org/x/net/context"
	"google.golang.org/grpc"
	"google.golang.org/grpc/reflection"
)

const (
	port = ":50051"
)

var version = "1"
var commit = ""

type server struct{}

func (s *server) Echo(ctx context.Context, in *rpc.MessageRequest) (*rpc.MessageReply, error) {
	log.Printf("SERVER: %s", in.Message)
	return &rpc.MessageReply{Message: in.Message}, nil
}

func main() {

	log.Printf("MUD v:%s c:%s", version, commit)

	lis, err := net.Listen("tcp", port)
	if err != nil {
		log.Fatalf("failed to listen: %v", err)
	}
	s := grpc.NewServer()
	rpc.RegisterMessagingServer(s, &server{})
	// Register reflection service on gRPC server.
	reflection.Register(s)
	if err := s.Serve(lis); err != nil {
		log.Fatalf("failed to serve: %v", err)
	}
}
