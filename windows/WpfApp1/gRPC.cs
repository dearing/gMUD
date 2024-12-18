﻿// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mud.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mud
{

    /// <summary>Holder for reflection information generated from mud.proto</summary>
    public static partial class MudReflection
    {

        #region Descriptor
        /// <summary>File descriptor for mud.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static MudReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "CgltdWQucHJvdG8SA211ZBofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5w",
                  "cm90byIaCgdNZXNzYWdlEg8KB21lc3NhZ2UYASABKAkiJgoFVG9rZW4SDAoE",
                  "dXVpZBgBIAEoCRIPCgdleHBpcmVzGAIgASgJIjIKDExvZ2luUmVxdWVzdBIQ",
                  "Cgh1c2VybmFtZRgBIAEoCRIQCghwYXNzd29yZBgCIAEoCSJiCgZBY3Rpb24S",
                  "IAoGYWN0aW9uGAEgASgOMhAubXVkLkFjdGlvbi5UeXBlEhAKCGFyZ3VtZW50",
                  "GAIgAygJIiQKBFR5cGUSBwoDU0FZEAASCQoFRU1PVEUQARIICgRMT09LEAIi",
                  "uAEKBlBsYXllchIMCgR1dWlkGAEgASgJEhAKCHVzZXJuYW1lGAIgASgJEgwK",
                  "BG5hbWUYAyABKAkSEwoLZGVzY3JpcHRpb24YBCABKAkSDgoGbG9naW5zGAUg",
                  "ASgEEisKB2NyZWF0ZWQYBiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0",
                  "YW1wEi4KCmxhc3RfbG9naW4YByABKAsyGi5nb29nbGUucHJvdG9idWYuVGlt",
                  "ZXN0YW1wMoMBCgRHYW1lEigKBUxvZ2luEhEubXVkLkxvZ2luUmVxdWVzdBoK",
                  "Lm11ZC5Ub2tlbiIAEigKBENoYXQSDC5tdWQuTWVzc2FnZRoMLm11ZC5NZXNz",
                  "YWdlIgAoATABEicKBVF1ZXVlEgsubXVkLkFjdGlvbhoLLm11ZC5QbGF5ZXIi",
                  "ACgBMAFiBnByb3RvMw=="));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
                new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mud.Message), global::Mud.Message.Parser, new[]{ "Message_" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mud.Token), global::Mud.Token.Parser, new[]{ "Uuid", "Expires" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mud.LoginRequest), global::Mud.LoginRequest.Parser, new[]{ "Username", "Password" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mud.Action), global::Mud.Action.Parser, new[]{ "Action_", "Argument" }, null, new[]{ typeof(global::Mud.Action.Types.Type) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mud.Player), global::Mud.Player.Parser, new[]{ "Uuid", "Username", "Name", "Description", "Logins", "Created", "LastLogin" }, null, null, null)
                }));
        }
        #endregion

    }
    #region Messages
    public sealed partial class Message : pb::IMessage<Message>
    {
        private static readonly pb::MessageParser<Message> _parser = new pb::MessageParser<Message>(() => new Message());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Message> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::Mud.MudReflection.Descriptor.MessageTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Message()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Message(Message other) : this()
        {
            message_ = other.message_;
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Message Clone()
        {
            return new Message(this);
        }

        /// <summary>Field number for the "message" field.</summary>
        public const int Message_FieldNumber = 1;
        private string message_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Message_
        {
            get { return message_; }
            set
            {
                message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as Message);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Message other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Message_ != other.Message_) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (Message_.Length != 0) hash ^= Message_.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Message_.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Message_);
            }
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(output);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (Message_.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Message_);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Message other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Message_.Length != 0)
            {
                Message_ = other.Message_;
            }
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                        break;
                    case 10:
                        {
                            Message_ = input.ReadString();
                            break;
                        }
                }
            }
        }

    }

    public sealed partial class Token : pb::IMessage<Token>
    {
        private static readonly pb::MessageParser<Token> _parser = new pb::MessageParser<Token>(() => new Token());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Token> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::Mud.MudReflection.Descriptor.MessageTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Token()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Token(Token other) : this()
        {
            uuid_ = other.uuid_;
            expires_ = other.expires_;
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Token Clone()
        {
            return new Token(this);
        }

        /// <summary>Field number for the "uuid" field.</summary>
        public const int UuidFieldNumber = 1;
        private string uuid_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Uuid
        {
            get { return uuid_; }
            set
            {
                uuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "expires" field.</summary>
        public const int ExpiresFieldNumber = 2;
        private string expires_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Expires
        {
            get { return expires_; }
            set
            {
                expires_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as Token);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Token other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Uuid != other.Uuid) return false;
            if (Expires != other.Expires) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (Uuid.Length != 0) hash ^= Uuid.GetHashCode();
            if (Expires.Length != 0) hash ^= Expires.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Uuid.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Uuid);
            }
            if (Expires.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Expires);
            }
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(output);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (Uuid.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Uuid);
            }
            if (Expires.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Expires);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Token other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Uuid.Length != 0)
            {
                Uuid = other.Uuid;
            }
            if (other.Expires.Length != 0)
            {
                Expires = other.Expires;
            }
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                        break;
                    case 10:
                        {
                            Uuid = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Expires = input.ReadString();
                            break;
                        }
                }
            }
        }

    }

    public sealed partial class LoginRequest : pb::IMessage<LoginRequest>
    {
        private static readonly pb::MessageParser<LoginRequest> _parser = new pb::MessageParser<LoginRequest>(() => new LoginRequest());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<LoginRequest> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::Mud.MudReflection.Descriptor.MessageTypes[2]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public LoginRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public LoginRequest(LoginRequest other) : this()
        {
            username_ = other.username_;
            password_ = other.password_;
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public LoginRequest Clone()
        {
            return new LoginRequest(this);
        }

        /// <summary>Field number for the "username" field.</summary>
        public const int UsernameFieldNumber = 1;
        private string username_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Username
        {
            get { return username_; }
            set
            {
                username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "password" field.</summary>
        public const int PasswordFieldNumber = 2;
        private string password_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Password
        {
            get { return password_; }
            set
            {
                password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as LoginRequest);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(LoginRequest other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Username != other.Username) return false;
            if (Password != other.Password) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (Username.Length != 0) hash ^= Username.GetHashCode();
            if (Password.Length != 0) hash ^= Password.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Username.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Username);
            }
            if (Password.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Password);
            }
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(output);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (Username.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
            }
            if (Password.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(LoginRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Username.Length != 0)
            {
                Username = other.Username;
            }
            if (other.Password.Length != 0)
            {
                Password = other.Password;
            }
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                        break;
                    case 10:
                        {
                            Username = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Password = input.ReadString();
                            break;
                        }
                }
            }
        }

    }

    public sealed partial class Action : pb::IMessage<Action>
    {
        private static readonly pb::MessageParser<Action> _parser = new pb::MessageParser<Action>(() => new Action());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Action> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::Mud.MudReflection.Descriptor.MessageTypes[3]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Action()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Action(Action other) : this()
        {
            action_ = other.action_;
            argument_ = other.argument_.Clone();
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Action Clone()
        {
            return new Action(this);
        }

        /// <summary>Field number for the "action" field.</summary>
        public const int Action_FieldNumber = 1;
        private global::Mud.Action.Types.Type action_ = 0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Mud.Action.Types.Type Action_
        {
            get { return action_; }
            set
            {
                action_ = value;
            }
        }

        /// <summary>Field number for the "argument" field.</summary>
        public const int ArgumentFieldNumber = 2;
        private static readonly pb::FieldCodec<string> _repeated_argument_codec
            = pb::FieldCodec.ForString(18);
        private readonly pbc::RepeatedField<string> argument_ = new pbc::RepeatedField<string>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<string> Argument
        {
            get { return argument_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as Action);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Action other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Action_ != other.Action_) return false;
            if (!argument_.Equals(other.argument_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (Action_ != 0) hash ^= Action_.GetHashCode();
            hash ^= argument_.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Action_ != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)Action_);
            }
            argument_.WriteTo(output, _repeated_argument_codec);
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(output);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (Action_ != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Action_);
            }
            size += argument_.CalculateSize(_repeated_argument_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Action other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Action_ != 0)
            {
                Action_ = other.Action_;
            }
            argument_.Add(other.argument_);
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                        break;
                    case 8:
                        {
                            action_ = (global::Mud.Action.Types.Type)input.ReadEnum();
                            break;
                        }
                    case 18:
                        {
                            argument_.AddEntriesFrom(input, _repeated_argument_codec);
                            break;
                        }
                }
            }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the Action message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static partial class Types
        {
            public enum Type
            {
                [pbr::OriginalName("SAY")] Say = 0,
                [pbr::OriginalName("EMOTE")] Emote = 1,
                [pbr::OriginalName("LOOK")] Look = 2,
            }

        }
        #endregion

    }

    public sealed partial class Player : pb::IMessage<Player>
    {
        private static readonly pb::MessageParser<Player> _parser = new pb::MessageParser<Player>(() => new Player());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Player> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::Mud.MudReflection.Descriptor.MessageTypes[4]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Player()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Player(Player other) : this()
        {
            uuid_ = other.uuid_;
            username_ = other.username_;
            name_ = other.name_;
            description_ = other.description_;
            logins_ = other.logins_;
            created_ = other.created_ != null ? other.created_.Clone() : null;
            lastLogin_ = other.lastLogin_ != null ? other.lastLogin_.Clone() : null;
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Player Clone()
        {
            return new Player(this);
        }

        /// <summary>Field number for the "uuid" field.</summary>
        public const int UuidFieldNumber = 1;
        private string uuid_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Uuid
        {
            get { return uuid_; }
            set
            {
                uuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "username" field.</summary>
        public const int UsernameFieldNumber = 2;
        private string username_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Username
        {
            get { return username_; }
            set
            {
                username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 3;
        private string name_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "description" field.</summary>
        public const int DescriptionFieldNumber = 4;
        private string description_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Description
        {
            get { return description_; }
            set
            {
                description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "logins" field.</summary>
        public const int LoginsFieldNumber = 5;
        private ulong logins_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ulong Logins
        {
            get { return logins_; }
            set
            {
                logins_ = value;
            }
        }

        /// <summary>Field number for the "created" field.</summary>
        public const int CreatedFieldNumber = 6;
        private global::Google.Protobuf.WellKnownTypes.Timestamp created_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Google.Protobuf.WellKnownTypes.Timestamp Created
        {
            get { return created_; }
            set
            {
                created_ = value;
            }
        }

        /// <summary>Field number for the "last_login" field.</summary>
        public const int LastLoginFieldNumber = 7;
        private global::Google.Protobuf.WellKnownTypes.Timestamp lastLogin_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Google.Protobuf.WellKnownTypes.Timestamp LastLogin
        {
            get { return lastLogin_; }
            set
            {
                lastLogin_ = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as Player);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Player other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Uuid != other.Uuid) return false;
            if (Username != other.Username) return false;
            if (Name != other.Name) return false;
            if (Description != other.Description) return false;
            if (Logins != other.Logins) return false;
            if (!object.Equals(Created, other.Created)) return false;
            if (!object.Equals(LastLogin, other.LastLogin)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (Uuid.Length != 0) hash ^= Uuid.GetHashCode();
            if (Username.Length != 0) hash ^= Username.GetHashCode();
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (Description.Length != 0) hash ^= Description.GetHashCode();
            if (Logins != 0UL) hash ^= Logins.GetHashCode();
            if (created_ != null) hash ^= Created.GetHashCode();
            if (lastLogin_ != null) hash ^= LastLogin.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Uuid.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Uuid);
            }
            if (Username.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Username);
            }
            if (Name.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(Name);
            }
            if (Description.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(Description);
            }
            if (Logins != 0UL)
            {
                output.WriteRawTag(40);
                output.WriteUInt64(Logins);
            }
            if (created_ != null)
            {
                output.WriteRawTag(50);
                output.WriteMessage(Created);
            }
            if (lastLogin_ != null)
            {
                output.WriteRawTag(58);
                output.WriteMessage(LastLogin);
            }
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(output);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (Uuid.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Uuid);
            }
            if (Username.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
            }
            if (Name.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
            }
            if (Description.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
            }
            if (Logins != 0UL)
            {
                size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Logins);
            }
            if (created_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Created);
            }
            if (lastLogin_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(LastLogin);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Player other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Uuid.Length != 0)
            {
                Uuid = other.Uuid;
            }
            if (other.Username.Length != 0)
            {
                Username = other.Username;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.Description.Length != 0)
            {
                Description = other.Description;
            }
            if (other.Logins != 0UL)
            {
                Logins = other.Logins;
            }
            if (other.created_ != null)
            {
                if (created_ == null)
                {
                    created_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
                }
                Created.MergeFrom(other.Created);
            }
            if (other.lastLogin_ != null)
            {
                if (lastLogin_ == null)
                {
                    lastLogin_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
                }
                LastLogin.MergeFrom(other.LastLogin);
            }
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                        break;
                    case 10:
                        {
                            Uuid = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Username = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            Name = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            Description = input.ReadString();
                            break;
                        }
                    case 40:
                        {
                            Logins = input.ReadUInt64();
                            break;
                        }
                    case 50:
                        {
                            if (created_ == null)
                            {
                                created_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(created_);
                            break;
                        }
                    case 58:
                        {
                            if (lastLogin_ == null)
                            {
                                lastLogin_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(lastLogin_);
                            break;
                        }
                }
            }
        }

    }

    #endregion

}

#endregion Designer generated code
