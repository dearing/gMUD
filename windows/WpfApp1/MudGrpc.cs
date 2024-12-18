﻿// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mud.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Mud
{
    public static partial class Game
    {
        static readonly string __ServiceName = "mud.Game";

        static readonly grpc::Marshaller<global::Mud.LoginRequest> __Marshaller_mud_LoginRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mud.LoginRequest.Parser.ParseFrom);
        static readonly grpc::Marshaller<global::Mud.Token> __Marshaller_mud_Token = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mud.Token.Parser.ParseFrom);
        static readonly grpc::Marshaller<global::Mud.Message> __Marshaller_mud_Message = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mud.Message.Parser.ParseFrom);
        static readonly grpc::Marshaller<global::Mud.Action> __Marshaller_mud_Action = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mud.Action.Parser.ParseFrom);
        static readonly grpc::Marshaller<global::Mud.Player> __Marshaller_mud_Player = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mud.Player.Parser.ParseFrom);

        static readonly grpc::Method<global::Mud.LoginRequest, global::Mud.Token> __Method_Login = new grpc::Method<global::Mud.LoginRequest, global::Mud.Token>(
            grpc::MethodType.Unary,
            __ServiceName,
            "Login",
            __Marshaller_mud_LoginRequest,
            __Marshaller_mud_Token);

        static readonly grpc::Method<global::Mud.Message, global::Mud.Message> __Method_Chat = new grpc::Method<global::Mud.Message, global::Mud.Message>(
            grpc::MethodType.DuplexStreaming,
            __ServiceName,
            "Chat",
            __Marshaller_mud_Message,
            __Marshaller_mud_Message);

        static readonly grpc::Method<global::Mud.Action, global::Mud.Player> __Method_Queue = new grpc::Method<global::Mud.Action, global::Mud.Player>(
            grpc::MethodType.DuplexStreaming,
            __ServiceName,
            "Queue",
            __Marshaller_mud_Action,
            __Marshaller_mud_Player);

        /// <summary>Service descriptor</summary>
        public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return global::Mud.MudReflection.Descriptor.Services[0]; }
        }

        /// <summary>Base class for server-side implementations of Game</summary>
        public abstract partial class GameBase
        {
            public virtual global::System.Threading.Tasks.Task<global::Mud.Token> Login(global::Mud.LoginRequest request, grpc::ServerCallContext context)
            {
                throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
            }

            public virtual global::System.Threading.Tasks.Task Chat(grpc::IAsyncStreamReader<global::Mud.Message> requestStream, grpc::IServerStreamWriter<global::Mud.Message> responseStream, grpc::ServerCallContext context)
            {
                throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
            }

            public virtual global::System.Threading.Tasks.Task Queue(grpc::IAsyncStreamReader<global::Mud.Action> requestStream, grpc::IServerStreamWriter<global::Mud.Player> responseStream, grpc::ServerCallContext context)
            {
                throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
            }

        }

        /// <summary>Client for Game</summary>
        public partial class GameClient : grpc::ClientBase<GameClient>
        {
            /// <summary>Creates a new client for Game</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public GameClient(grpc::Channel channel) : base(channel)
            {
            }
            /// <summary>Creates a new client for Game that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public GameClient(grpc::CallInvoker callInvoker) : base(callInvoker)
            {
            }
            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected GameClient() : base()
            {
            }
            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected GameClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            public virtual global::Mud.Token Login(global::Mud.LoginRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
            {
                return Login(request, new grpc::CallOptions(headers, deadline, cancellationToken));
            }
            public virtual global::Mud.Token Login(global::Mud.LoginRequest request, grpc::CallOptions options)
            {
                return CallInvoker.BlockingUnaryCall(__Method_Login, null, options, request);
            }
            public virtual grpc::AsyncUnaryCall<global::Mud.Token> LoginAsync(global::Mud.LoginRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
            {
                return LoginAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
            }
            public virtual grpc::AsyncUnaryCall<global::Mud.Token> LoginAsync(global::Mud.LoginRequest request, grpc::CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_Login, null, options, request);
            }
            public virtual grpc::AsyncDuplexStreamingCall<global::Mud.Message, global::Mud.Message> Chat(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
            {
                return Chat(new grpc::CallOptions(headers, deadline, cancellationToken));
            }
            public virtual grpc::AsyncDuplexStreamingCall<global::Mud.Message, global::Mud.Message> Chat(grpc::CallOptions options)
            {
                return CallInvoker.AsyncDuplexStreamingCall(__Method_Chat, null, options);
            }
            public virtual grpc::AsyncDuplexStreamingCall<global::Mud.Action, global::Mud.Player> Queue(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
            {
                return Queue(new grpc::CallOptions(headers, deadline, cancellationToken));
            }
            public virtual grpc::AsyncDuplexStreamingCall<global::Mud.Action, global::Mud.Player> Queue(grpc::CallOptions options)
            {
                return CallInvoker.AsyncDuplexStreamingCall(__Method_Queue, null, options);
            }
            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override GameClient NewInstance(ClientBaseConfiguration configuration)
            {
                return new GameClient(configuration);
            }
        }

        /// <summary>Creates service definition that can be registered with a server</summary>
        /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
        public static grpc::ServerServiceDefinition BindService(GameBase serviceImpl)
        {
            return grpc::ServerServiceDefinition.CreateBuilder()
                .AddMethod(__Method_Login, serviceImpl.Login)
                .AddMethod(__Method_Chat, serviceImpl.Chat)
                .AddMethod(__Method_Queue, serviceImpl.Queue).Build();
        }

    }
}
#endregion
