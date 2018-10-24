
# gMUD

A MUD built with gRPC for fun and research.

## BUILD

### GO

First we need to generate some protobuf Go code.
```
protoc -I . --go_out=plugins=grpc:. mud.proto
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

### DART
```
protoc mud.proto --plugin=protoc-gen-dart=c:\Users\JacobDearing\AppData\Roaming\Pub\Cache\bin\protoc-gen-dart.bat --dart_out=grpc:.\dart\lib\src\generated
```

### C#
```
protoc --proto_path=. --csharp_out --grpc_out=. .\  .\mud.proto
```

Almost forgot the gRPC class, removing the stupid appcache broken stuff to a %PATH% bin
```
protoc.exe --csharp_out Mud --grpc_out Mud .\mud.proto --plugin=protoc-gen-grpc=C:\bin\grpc_csharp_plugin.exe
```

### experimental web javascript
```
cd ..
protoc --proto_path=. --js_out=library=mud_client,binary:web/js .\mud.proto
protoc --js_out=import_style=commonjs,binary:. messages.proto base.proto
grpc_tools_node_protoc --js_out=import_style=commonjs,binary:. --grpc_out=. mud.proto
```

