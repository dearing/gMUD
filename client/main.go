package main

import (
	"bufio"
	"context"
	"fmt"
	"io"
	"log"
	"os"

	"google.golang.org/grpc"

	"github.com/dearing/mud"
)

const (
	address     = "localhost:50051"
	defaultName = "world"
)

var version = "1.1"
var commit = ""

type client struct{}

func echo(client mud.MessagingClient) {

	stream, err := client.Echo(context.Background())
	if err != nil {
		log.Fatalf("%v.Echo(_) = _, %v", client, err)
	}
	waitc := make(chan struct{})
	go func() {
		for {
			in, err := stream.Recv()
			if err == io.EOF {
				// read done.
				close(waitc)
				return
			}
			if err != nil {
				log.Fatalf("Failed to receive a note : %v", err)
			}
			log.Printf("SERVER: %s\n", in.Message)
		}
	}()
	for {
		reader := bufio.NewReader(os.Stdin)
		fmt.Print("CLIENT: Enter text: ")
		text, _ := reader.ReadString('\n')
		if text == "exit" {
			break
		}
		if err := stream.Send(&mud.MessageRequest{Message: text}); err != nil {
			log.Fatalf("Failed to send a message: %v", err)
		}
	}
	stream.CloseSend()
	<-waitc
}

func main() {

	log.Printf("MUD v%s c:%s", version, commit)

	conn, err := grpc.Dial(address, grpc.WithInsecure())
	if err != nil {
		log.Fatalf("did not connect: %v", err)
	}
	defer conn.Close()

	mudClient := mud.NewMessagingClient(conn)

	echo(mudClient)

}
