package main

import (
	"context"
	"log"
	"time"

	"google.golang.org/grpc"

	"github.com/dearing/mud"
)

const (
	address     = "localhost:50051"
	defaultName = "world"
)

var version = "1"
var commit = ""

type client struct{}

func main() {

	log.Printf("MUD v%s c:%s", version, commit)
	conn, err := grpc.Dial(address, grpc.WithInsecure())
	if err != nil {
		log.Fatalf("did not connect: %v", err)
	}
	defer conn.Close()
	mudClient := mud.NewMessagingClient(conn)

	ctx, cancel := context.WithTimeout(context.Background(), time.Second)
	defer cancel()

	r, err := mudClient.Echo(ctx, &mud.MessageRequest{Message: "Hello World!"})
	if err != nil {
		log.Fatalf("could not connect: %v", err)
	}
	log.Printf("CLIENT: %s", r.Message)

}
