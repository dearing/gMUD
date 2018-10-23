///
//  Generated code. Do not modify.
//  source: mud.proto
///
// ignore_for_file: non_constant_identifier_names,library_prefixes,unused_import

// ignore_for_file: UNDEFINED_SHOWN_NAME,UNUSED_SHOWN_NAME
import 'dart:core' show int, dynamic, String, List, Map;
import 'package:protobuf/protobuf.dart' as $pb;

class Action_Type extends $pb.ProtobufEnum {
  static const Action_Type SAY = const Action_Type._(0, 'SAY');
  static const Action_Type EMOTE = const Action_Type._(1, 'EMOTE');
  static const Action_Type LOOK = const Action_Type._(2, 'LOOK');

  static const List<Action_Type> values = const <Action_Type> [
    SAY,
    EMOTE,
    LOOK,
  ];

  static final Map<int, Action_Type> _byValue = $pb.ProtobufEnum.initByValue(values);
  static Action_Type valueOf(int value) => _byValue[value];
  static void $checkItem(Action_Type v) {
    if (v is! Action_Type) $pb.checkItemFailed(v, 'Action_Type');
  }

  const Action_Type._(int v, String n) : super(v, n);
}

