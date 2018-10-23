
# gMUD

A MUD built with gRPC for fun and research.

## BUILD


First we need to generate some protobuf Go code.
```
protoc -I . --go_out=plugins=grpc:. mud.proto
```

experimental web javascript
```
cd ..
protoc --proto_path=. --js_out=library=mud_client,binary:web/js .\mud.proto
```

```
protoc --proto_path=. --csharp_out .\  .\mud.proto
```

Now we can build out the server for our platform with a commit hash for good measure.
```
cd ..\server
go build -ldflags "-X main.commit=$(git rev-parse HEAD)" -o ..\server.exe
```

Finally we can build out the cli client for our platform with a commit hash for good measure.
```
cd ..\client
go build -ldflags "-X main.commit=$(git rev-parse HEAD)" -o ..\client.exe
```

