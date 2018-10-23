///
//  Generated code. Do not modify.
//  source: mud.proto
///
// ignore_for_file: non_constant_identifier_names,library_prefixes,unused_import

// ignore: UNUSED_SHOWN_NAME
import 'dart:core' show int, bool, double, String, List, override;

import 'package:fixnum/fixnum.dart';
import 'package:protobuf/protobuf.dart' as $pb;


// minor hack
import 'google.timestamp.pb.dart' as $0;

import 'mud.pbenum.dart';

export 'mud.pbenum.dart';

class Message extends $pb.GeneratedMessage {
  static final $pb.BuilderInfo _i = new $pb.BuilderInfo('Message', package: const $pb.PackageName('mud'))
    ..aOS(1, 'message')
    ..hasRequiredFields = false
  ;

  Message() : super();
  Message.fromBuffer(List<int> i, [$pb.ExtensionRegistry r = $pb.ExtensionRegistry.EMPTY]) : super.fromBuffer(i, r);
  Message.fromJson(String i, [$pb.ExtensionRegistry r = $pb.ExtensionRegistry.EMPTY]) : super.fromJson(i, r);
  Message clone() => new Message()..mergeFromMessage(this);
  Message copyWith(void Function(Message) updates) => super.copyWith((message) => updates(message as Message));
  $pb.BuilderInfo get info_ => _i;
  static Message create() => new Message();
  static $pb.PbList<Message> createRepeated() => new $pb.PbList<Message>();
  static Message getDefault() => _defaultInstance ??= create()..freeze();
  static Message _defaultInstance;
  static void $checkItem(Message v) {
    if (v is! Message) $pb.checkItemFailed(v, _i.qualifiedMessageName);
  }

  String get message => $_getS(0, '');
  set message(String v) { $_setString(0, v); }
  bool hasMessage() => $_has(0);
  void clearMessage() => clearField(1);
}

class Token extends $pb.GeneratedMessage {
  static final $pb.BuilderInfo _i = new $pb.BuilderInfo('Token', package: const $pb.PackageName('mud'))
    ..aOS(1, 'uuid')
    ..aOS(2, 'expires')
    ..hasRequiredFields = false
  ;

  Token() : super();
  Token.fromBuffer(List<int> i, [$pb.ExtensionRegistry r = $pb.ExtensionRegistry.EMPTY]) : super.fromBuffer(i, r);
  Token.fromJson(String i, [$pb.ExtensionRegistry r = $pb.ExtensionRegistry.EMPTY]) : super.fromJson(i, r);
  Token clone() => new Token()..mergeFromMessage(this);
  Token copyWith(void Function(Token) updates) => super.copyWith((message) => updates(message as Token));
  $pb.BuilderInfo get info_ => _i;
  static Token create() => new Token();
  static $pb.PbList<Token> createRepeated() => new $pb.PbList<Token>();
  static Token getDefault() => _defaultInstance ??= create()..freeze();
  static Token _defaultInstance;
  static void $checkItem(Token v) {
    if (v is! Token) $pb.checkItemFailed(v, _i.qualifiedMessageName);
  }

  String get uuid => $_getS(0, '');
  set uuid(String v) { $_setString(0, v); }
  bool hasUuid() => $_has(0);
  void clearUuid() => clearField(1);

  String get expires => $_getS(1, '');
  set expires(String v) { $_setString(1, v); }
  bool hasExpires() => $_has(1);
  void clearExpires() => clearField(2);
}

class LoginRequest extends $pb.GeneratedMessage {
  static final $pb.BuilderInfo _i = new $pb.BuilderInfo('LoginRequest', package: const $pb.PackageName('mud'))
    ..aOS(1, 'username')
    ..aOS(2, 'password')
    ..hasRequiredFields = false
  ;

  LoginRequest() : super();
  LoginRequest.fromBuffer(List<int> i, [$pb.ExtensionRegistry r = $pb.ExtensionRegistry.EMPTY]) : super.fromBuffer(i, r);
  LoginRequest.fromJson(String i, [$pb.ExtensionRegistry r = $pb.ExtensionRegistry.EMPTY]) : super.fromJson(i, r);
  LoginRequest clone() => new LoginRequest()..mergeFromMessage(this);
  LoginRequest copyWith(void Function(LoginRequest) updates) => super.copyWith((message) => updates(message as LoginRequest));
  $pb.BuilderInfo get info_ => _i;
  static LoginRequest create() => new LoginRequest();
  static $pb.PbList<LoginRequest> createRepeated() => new $pb.PbList<LoginRequest>();
  static LoginRequest getDefault() => _defaultInstance ??= create()..freeze();
  static LoginRequest _defaultInstance;
  static void $checkItem(LoginRequest v) {
    if (v is! LoginRequest) $pb.checkItemFailed(v, _i.qualifiedMessageName);
  }

  String get username => $_getS(0, '');
  set username(String v) { $_setString(0, v); }
  bool hasUsername() => $_has(0);
  void clearUsername() => clearField(1);

  String get password => $_getS(1, '');
  set password(String v) { $_setString(1, v); }
  bool hasPassword() => $_has(1);
  void clearPassword() => clearField(2);
}

class Action extends $pb.GeneratedMessage {
  static final $pb.BuilderInfo _i = new $pb.BuilderInfo('Action', package: const $pb.PackageName('mud'))
    ..e<Action_Type>(1, 'action', $pb.PbFieldType.OE, Action_Type.SAY, Action_Type.valueOf, Action_Type.values)
    ..pPS(2, 'argument')
    ..hasRequiredFields = false
  ;

  Action() : super();
  Action.fromBuffer(List<int> i, [$pb.ExtensionRegistry r = $pb.ExtensionRegistry.EMPTY]) : super.fromBuffer(i, r);
  Action.fromJson(String i, [$pb.ExtensionRegistry r = $pb.ExtensionRegistry.EMPTY]) : super.fromJson(i, r);
  Action clone() => new Action()..mergeFromMessage(this);
  Action copyWith(void Function(Action) updates) => super.copyWith((message) => updates(message as Action));
  $pb.BuilderInfo get info_ => _i;
  static Action create() => new Action();
  static $pb.PbList<Action> createRepeated() => new $pb.PbList<Action>();
  static Action getDefault() => _defaultInstance ??= create()..freeze();
  static Action _defaultInstance;
  static void $checkItem(Action v) {
    if (v is! Action) $pb.checkItemFailed(v, _i.qualifiedMessageName);
  }

  Action_Type get action => $_getN(0);
  set action(Action_Type v) { setField(1, v); }
  bool hasAction() => $_has(0);
  void clearAction() => clearField(1);

  List<String> get argument => $_getList(1);
}

class Player extends $pb.GeneratedMessage {
  static final $pb.BuilderInfo _i = new $pb.BuilderInfo('Player', package: const $pb.PackageName('mud'))
    ..aOS(1, 'uuid')
    ..aOS(2, 'username')
    ..aOS(3, 'name')
    ..aOS(4, 'description')
    ..a<Int64>(5, 'logins', $pb.PbFieldType.OU6, Int64.ZERO)
    ..a<$0.Timestamp>(6, 'created', $pb.PbFieldType.OM, $0.Timestamp.getDefault, $0.Timestamp.create)
    ..a<$0.Timestamp>(7, 'lastLogin', $pb.PbFieldType.OM, $0.Timestamp.getDefault, $0.Timestamp.create)
    ..hasRequiredFields = false
  ;

  Player() : super();
  Player.fromBuffer(List<int> i, [$pb.ExtensionRegistry r = $pb.ExtensionRegistry.EMPTY]) : super.fromBuffer(i, r);
  Player.fromJson(String i, [$pb.ExtensionRegistry r = $pb.ExtensionRegistry.EMPTY]) : super.fromJson(i, r);
  Player clone() => new Player()..mergeFromMessage(this);
  Player copyWith(void Function(Player) updates) => super.copyWith((message) => updates(message as Player));
  $pb.BuilderInfo get info_ => _i;
  static Player create() => new Player();
  static $pb.PbList<Player> createRepeated() => new $pb.PbList<Player>();
  static Player getDefault() => _defaultInstance ??= create()..freeze();
  static Player _defaultInstance;
  static void $checkItem(Player v) {
    if (v is! Player) $pb.checkItemFailed(v, _i.qualifiedMessageName);
  }

  String get uuid => $_getS(0, '');
  set uuid(String v) { $_setString(0, v); }
  bool hasUuid() => $_has(0);
  void clearUuid() => clearField(1);

  String get username => $_getS(1, '');
  set username(String v) { $_setString(1, v); }
  bool hasUsername() => $_has(1);
  void clearUsername() => clearField(2);

  String get name => $_getS(2, '');
  set name(String v) { $_setString(2, v); }
  bool hasName() => $_has(2);
  void clearName() => clearField(3);

  String get description => $_getS(3, '');
  set description(String v) { $_setString(3, v); }
  bool hasDescription() => $_has(3);
  void clearDescription() => clearField(4);

  Int64 get logins => $_getI64(4);
  set logins(Int64 v) { $_setInt64(4, v); }
  bool hasLogins() => $_has(4);
  void clearLogins() => clearField(5);

  $0.Timestamp get created => $_getN(5);
  set created($0.Timestamp v) { setField(6, v); }
  bool hasCreated() => $_has(5);
  void clearCreated() => clearField(6);

  $0.Timestamp get lastLogin => $_getN(6);
  set lastLogin($0.Timestamp v) { setField(7, v); }
  bool hasLastLogin() => $_has(6);
  void clearLastLogin() => clearField(7);
}

