// GENERATED CODE -- DO NOT EDIT!

'use strict';
var grpc = require('grpc');
var mud_pb = require('./mud_pb.js');
var google_protobuf_timestamp_pb = require('google-protobuf/google/protobuf/timestamp_pb.js');

function serialize_mud_Action(arg) {
  if (!(arg instanceof mud_pb.Action)) {
    throw new Error('Expected argument of type mud.Action');
  }
  return new Buffer(arg.serializeBinary());
}

function deserialize_mud_Action(buffer_arg) {
  return mud_pb.Action.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_mud_LoginRequest(arg) {
  if (!(arg instanceof mud_pb.LoginRequest)) {
    throw new Error('Expected argument of type mud.LoginRequest');
  }
  return new Buffer(arg.serializeBinary());
}

function deserialize_mud_LoginRequest(buffer_arg) {
  return mud_pb.LoginRequest.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_mud_Message(arg) {
  if (!(arg instanceof mud_pb.Message)) {
    throw new Error('Expected argument of type mud.Message');
  }
  return new Buffer(arg.serializeBinary());
}

function deserialize_mud_Message(buffer_arg) {
  return mud_pb.Message.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_mud_Player(arg) {
  if (!(arg instanceof mud_pb.Player)) {
    throw new Error('Expected argument of type mud.Player');
  }
  return new Buffer(arg.serializeBinary());
}

function deserialize_mud_Player(buffer_arg) {
  return mud_pb.Player.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_mud_Token(arg) {
  if (!(arg instanceof mud_pb.Token)) {
    throw new Error('Expected argument of type mud.Token');
  }
  return new Buffer(arg.serializeBinary());
}

function deserialize_mud_Token(buffer_arg) {
  return mud_pb.Token.deserializeBinary(new Uint8Array(buffer_arg));
}


var GameService = exports.GameService = {
  login: {
    path: '/mud.Game/Login',
    requestStream: false,
    responseStream: false,
    requestType: mud_pb.LoginRequest,
    responseType: mud_pb.Token,
    requestSerialize: serialize_mud_LoginRequest,
    requestDeserialize: deserialize_mud_LoginRequest,
    responseSerialize: serialize_mud_Token,
    responseDeserialize: deserialize_mud_Token,
  },
  chat: {
    path: '/mud.Game/Chat',
    requestStream: true,
    responseStream: true,
    requestType: mud_pb.Message,
    responseType: mud_pb.Message,
    requestSerialize: serialize_mud_Message,
    requestDeserialize: deserialize_mud_Message,
    responseSerialize: serialize_mud_Message,
    responseDeserialize: deserialize_mud_Message,
  },
  queue: {
    path: '/mud.Game/Queue',
    requestStream: true,
    responseStream: true,
    requestType: mud_pb.Action,
    responseType: mud_pb.Player,
    requestSerialize: serialize_mud_Action,
    requestDeserialize: deserialize_mud_Action,
    responseSerialize: serialize_mud_Player,
    responseDeserialize: deserialize_mud_Player,
  },
};

exports.GameClient = grpc.makeGenericClientConstructor(GameService);
