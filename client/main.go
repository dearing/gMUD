package main

import (
	"bufio"
	"context"
	"flag"
	"fmt"
	"io"
	"log"
	"os"

	"github.com/dearing/mud"
	"github.com/jroimartin/gocui"
	"google.golang.org/grpc"
	"google.golang.org/grpc/credentials"
	"google.golang.org/grpc/metadata"
)

var (
	version = "1.6"
	commit  = ""
	addr    = flag.String("addr", "localhost:50051", "MUD server address")
	crt     = flag.String("crt", "./misc/localhost.crt", "MUD server cert")
)

type client struct{}

var sessionToken string

func chat(client mud.GameClient) {

	md := metadata.Pairs("token", sessionToken)

	ctx := metadata.NewOutgoingContext(context.Background(), md)

	stream, err := client.Chat(ctx)
	if err != nil {
		log.Fatalf("%+v.CHAT: %v", client, err)
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
		if err := stream.Send(&mud.Message{Message: text}); err != nil {
			log.Fatalf("Failed to send a message: %v", err)
		}
	}
	stream.CloseSend()
	<-waitc
}

func queue(client mud.GameClient) {

	md := metadata.Pairs("token", sessionToken)
	ctx := metadata.NewOutgoingContext(context.Background(), md)

	stream, err := client.Queue(ctx)
	if err != nil {
		log.Fatalf("%+v.QUEUE: %v", client, err)
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
				log.Fatalf("Failed to receive a player: %v", err)
			}
			log.Printf("\nSERVER: %+v\n", in)
		}
	}()
	for {
		reader := bufio.NewReader(os.Stdin)
		fmt.Print("\nQUEUE: Enter speech: ")
		text, _ := reader.ReadString('\n')
		if text == "exit" {
			break
		}

		args := []string{text}

		if err := stream.Send(&mud.Action{Argument: args}); err != nil {
			log.Fatalf("Failed to send a action: %v", err)
		}
	}
	stream.CloseSend()
	<-waitc
}

func login(client mud.GameClient) (err error) {

	token, err := client.Login(context.Background(), &mud.LoginRequest{
		Username: "admin",
		Password: "password",
	})

	sessionToken = token.Uuid

	return
}

var player *mud.Player

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

	mudClient := mud.NewGameClient(conn)

	err = login(mudClient)
	if err != nil {
		log.Fatalf("Failed to login! %v", err)
	} else {
		log.Printf("TOKEN: %v", sessionToken)
	}

	g, err := gocui.NewGui(gocui.OutputNormal)
	if err != nil {
		log.Panicln(err)
	}
	defer g.Close()

	g.SetManagerFunc(layout)

	if err := g.SetKeybinding("", gocui.KeyCtrlC, gocui.ModNone, quit); err != nil {
		log.Panicln(err)
	}

	if err := g.MainLoop(); err != nil && err != gocui.ErrQuit {
		log.Panicln(err)
	}

	//chat(mudClient)
	queue(mudClient)
}

func layout(g *gocui.Gui) error {
	maxX, maxY := g.Size()
	if v, err := g.SetView("hello", maxX/2-7, maxY/2, maxX/2+7, maxY/2+2); err != nil {
		if err != gocui.ErrUnknownView {
			return err
		}
		fmt.Fprintln(v, "Hello world!")
	}
	return nil
}

func quit(g *gocui.Gui, v *gocui.View) error {
	return gocui.ErrQuit
}
