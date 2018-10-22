package main

import (
	"context"
	"log"

	"google.golang.org/grpc"
	"google.golang.org/grpc/codes"
	"google.golang.org/grpc/metadata"
	"google.golang.org/grpc/status"
)

func unaryInterceptor(ctx context.Context, req interface{}, info *grpc.UnaryServerInfo, handler grpc.UnaryHandler) (interface{}, error) {

	log.Printf("unaryInterceptor: %+v", info)

	if info.FullMethod != "/mud.Game/Login" {
		if err := authorize(ctx); err != nil {
			return nil, err
		}
	}

	return handler(ctx, req)
}

func streamInterceptor(srv interface{}, stream grpc.ServerStream, info *grpc.StreamServerInfo, handler grpc.StreamHandler) error {

	log.Printf("streamInterceptor: %+v", info)

	if err := authorize(stream.Context()); err != nil {
		return err
	}

	return handler(srv, stream)

}

func authorize(ctx context.Context) error {
	md, ok := metadata.FromIncomingContext(ctx)
	if !ok {
		return status.Errorf(codes.InvalidArgument, "Retrieving metadata is failed")
	}

	authHeader, ok := md["token"]
	if !ok {
		return status.Errorf(codes.Unauthenticated, "Authorization token is not supplied")
	}

	token := authHeader[0]
	// validateToken function validates the token
	err := validateToken(token)

	if err != nil {
		return status.Errorf(codes.Unauthenticated, err.Error())
	}
	return nil
}

func validateToken(token string) (err error) {
	log.Printf("SERVER: TOKEN %v", token)
	for _, t := range sessions {
		if t.token == token {
			return nil
		}
	}
	return status.Errorf(codes.Unauthenticated, "Authorization token is not found.")
}
