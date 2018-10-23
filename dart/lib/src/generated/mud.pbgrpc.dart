///
//  Generated code. Do not modify.
//  source: mud.proto
///
// ignore_for_file: non_constant_identifier_names,library_prefixes,unused_import

import 'dart:async' as $async;

import 'package:grpc/grpc.dart';

import 'mud.pb.dart';
export 'mud.pb.dart';

class GameClient extends Client {
  static final _$login = new ClientMethod<LoginRequest, Token>(
      '/mud.Game/Login',
      (LoginRequest value) => value.writeToBuffer(),
      (List<int> value) => new Token.fromBuffer(value));
  static final _$chat = new ClientMethod<Message, Message>(
      '/mud.Game/Chat',
      (Message value) => value.writeToBuffer(),
      (List<int> value) => new Message.fromBuffer(value));
  static final _$queue = new ClientMethod<Action, Player>(
      '/mud.Game/Queue',
      (Action value) => value.writeToBuffer(),
      (List<int> value) => new Player.fromBuffer(value));

  GameClient(ClientChannel channel, {CallOptions options})
      : super(channel, options: options);

  ResponseFuture<Token> login(LoginRequest request, {CallOptions options}) {
    final call = $createCall(_$login, new $async.Stream.fromIterable([request]),
        options: options);
    return new ResponseFuture(call);
  }

  ResponseStream<Message> chat($async.Stream<Message> request,
      {CallOptions options}) {
    final call = $createCall(_$chat, request, options: options);
    return new ResponseStream(call);
  }

  ResponseStream<Player> queue($async.Stream<Action> request,
      {CallOptions options}) {
    final call = $createCall(_$queue, request, options: options);
    return new ResponseStream(call);
  }
}

abstract class GameServiceBase extends Service {
  String get $name => 'mud.Game';

  GameServiceBase() {
    $addMethod(new ServiceMethod<LoginRequest, Token>(
        'Login',
        login_Pre,
        false,
        false,
        (List<int> value) => new LoginRequest.fromBuffer(value),
        (Token value) => value.writeToBuffer()));
    $addMethod(new ServiceMethod<Message, Message>(
        'Chat',
        chat,
        true,
        true,
        (List<int> value) => new Message.fromBuffer(value),
        (Message value) => value.writeToBuffer()));
    $addMethod(new ServiceMethod<Action, Player>(
        'Queue',
        queue,
        true,
        true,
        (List<int> value) => new Action.fromBuffer(value),
        (Player value) => value.writeToBuffer()));
  }

  $async.Future<Token> login_Pre(
      ServiceCall call, $async.Future request) async {
    return login(call, await request);
  }

  $async.Future<Token> login(ServiceCall call, LoginRequest request);
  $async.Stream<Message> chat(ServiceCall call, $async.Stream<Message> request);
  $async.Stream<Player> queue(ServiceCall call, $async.Stream<Action> request);
}
