
# MUD

## BUILD
```
cd ..\server
go build -ldflags "-X main.commit=$(git rev-parse HEAD)" -o ..\server.exe
cd ..\client
go build -ldflags "-X main.commit=$(git rev-parse HEAD)" -o ..\client.exe
```