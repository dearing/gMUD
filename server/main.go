//go:generate protoc -I ../coms --go_out=plugins=grpc:../coms ../coms/coms.proto

package main

import (
	"log"
	"net"

	rpc "github.com/dearing/mud/rpc"
	"golang.org/x/net/context"
	"google.golang.org/grpc"
	"google.golang.org/grpc/reflection"
)

const (
	port = ":50051"
)

type server struct{}

func (s *server) Message(ctx context.Context, in *rpc.MessageRequest) (*rpc.MessageReply, error) {
	return &rpc.MessageReply{Message: "Hello " + in.Message}, nil
}

func main() {
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
