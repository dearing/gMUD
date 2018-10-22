package main

import (
	"bufio"
	"context"
	"flag"
	"fmt"
	"io"
	"log"
	"os"

	"google.golang.org/grpc"
	"google.golang.org/grpc/credentials"

	"github.com/dearing/mud"
)

var (
	version = "1.3"
	commit  = ""
	addr    = flag.String("addr", "localhost:50051", "MUD server address")
	crt     = flag.String("crt", "./misc/localhost.crt", "MUD server cert")
)

type client struct{}

func echo(client mud.MessagingClient) {

	stream, err := client.Echo(context.Background())
	if err != nil {
		log.Fatalf("%+v.Echo: %v", client, err)
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
				log.Fatalf("Failed to receive a message : %v", err)
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
	flag.Parse()

	creds, err := credentials.NewClientTLSFromFile(*crt, "")
	if err != nil {
		log.Fatalf("could not load tls cert: %s", err)
	}

	conn, err := grpc.Dial(*addr, grpc.WithTransportCredentials(creds))
	if err != nil {
		log.Fatalf("did not connect: %v", err)
	}
	defer conn.Close()

	mudClient := mud.NewMessagingClient(conn)

	echo(mudClient)

}
