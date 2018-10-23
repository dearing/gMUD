///
//  Generated code. Do not modify.
//  source: mud.proto
///
// ignore_for_file: non_constant_identifier_names,library_prefixes,unused_import

const Message$json = const {
  '1': 'Message',
  '2': const [
    const {'1': 'message', '3': 1, '4': 1, '5': 9, '10': 'message'},
  ],
};

const Token$json = const {
  '1': 'Token',
  '2': const [
    const {'1': 'uuid', '3': 1, '4': 1, '5': 9, '10': 'uuid'},
    const {'1': 'expires', '3': 2, '4': 1, '5': 9, '10': 'expires'},
  ],
};

const LoginRequest$json = const {
  '1': 'LoginRequest',
  '2': const [
    const {'1': 'username', '3': 1, '4': 1, '5': 9, '10': 'username'},
    const {'1': 'password', '3': 2, '4': 1, '5': 9, '10': 'password'},
  ],
};

const Action$json = const {
  '1': 'Action',
  '2': const [
    const {'1': 'action', '3': 1, '4': 1, '5': 14, '6': '.mud.Action.Type', '10': 'action'},
    const {'1': 'argument', '3': 2, '4': 3, '5': 9, '10': 'argument'},
  ],
  '4': const [Action_Type$json],
};

const Action_Type$json = const {
  '1': 'Type',
  '2': const [
    const {'1': 'SAY', '2': 0},
    const {'1': 'EMOTE', '2': 1},
    const {'1': 'LOOK', '2': 2},
  ],
};

const Player$json = const {
  '1': 'Player',
  '2': const [
    const {'1': 'uuid', '3': 1, '4': 1, '5': 9, '10': 'uuid'},
    const {'1': 'username', '3': 2, '4': 1, '5': 9, '10': 'username'},
    const {'1': 'name', '3': 3, '4': 1, '5': 9, '10': 'name'},
    const {'1': 'description', '3': 4, '4': 1, '5': 9, '10': 'description'},
    const {'1': 'logins', '3': 5, '4': 1, '5': 4, '10': 'logins'},
    const {'1': 'created', '3': 6, '4': 1, '5': 11, '6': '.google.protobuf.Timestamp', '10': 'created'},
    const {'1': 'last_login', '3': 7, '4': 1, '5': 11, '6': '.google.protobuf.Timestamp', '10': 'lastLogin'},
  ],
};

