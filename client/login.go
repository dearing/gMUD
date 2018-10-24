package main

import (
	"fmt"
	"log"

	"github.com/dearing/mud"
	"github.com/gdamore/tcell"
	"github.com/rivo/tview"
	"google.golang.org/grpc"
)

// app := tview.NewApplication()
// form := tview.NewForm().
// 	AddInputField("Username", "", 20, nil, nil).
// 	AddPasswordField("Password", "", 10, '*', nil).
// 	AddButton("Login", nil).
// 	AddButton("Quit", func() {
// 		app.Stop()
// 	})
// form.SetBorder(true).SetTitle("Enter some data").SetTitleAlign(tview.AlignCenter)
// if err := app.SetRoot(form, true).SetFocus(form).Run(); err != nil {
// 	panic(err)
// }

func flogin() {

	app := tview.NewApplication()

	banner := tview.NewBox().SetBorder(true).SetTitle(*addr)
	view := tview.NewBox().SetBorder(true).SetTitle("view")
	//lower := tview.NewBox().SetBorder(true).SetTitle("input")
	input := tview.NewInputField().SetLabel("input: ").SetPlaceholder("Hello World!")

	input.SetDoneFunc(func(key tcell.Key) {
		switch key {
		case tcell.KeyEnter:
			//tview.PrintSimple(view, input.GetText())
		}
	})

	//lower := tview.NewFlex().AddItem(tview.NewInputField().SetLabel("input: ").SetPlaceholder("Hello World!"), 0, 1, false)

	//lower.AddItem(input)

	flex := tview.NewFlex().
		AddItem(tview.NewFlex().SetDirection(tview.FlexRow).
			AddItem(banner, 3, 1, false).
			AddItem(view, 0, 1, false).
			AddItem(input, 0, 1, false), 0, 1, false)

	if err := app.SetRoot(flex, true).SetFocus(input).Run(); err != nil {
		log.Fatalf("flogin:\n%+v", err)
	}

}

func testText() {

	app := tview.NewApplication()
	textView := tview.NewTextView().
		SetDynamicColors(true).
		SetRegions(true).
		SetChangedFunc(func() {
			app.Draw()
		})
	go func() {
		conn, err := grpc.Dial(*addr, grpc.WithInsecure())
		if err != nil {
			log.Fatalf("did not connect: %v", err)
		}
		defer conn.Close()

		mudClient := mud.NewGameClient(conn)
		err = login(mudClient)
		if err != nil {
			log.Fatalf("Failed to login! %v", err)
		} else {
			//log.Printf("TOKEN: %v", sessionToken)
			fmt.Fprintf(textView, "%+v ", sessionToken)
			textView.SetTitle(*addr).SetTitleAlign(tview.AlignCenter)
		}

		chat(mudClient)

	}()
	textView.SetBorder(true)
	if err := app.SetRoot(textView, true).SetFocus(textView).Run(); err != nil {
		panic(err)
	}
}
