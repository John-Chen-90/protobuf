// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/protobuf/unittest_import_public_proto3.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.TestProtos {

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class UnittestImportPublicProto3 {

    #region Static variables
    internal static pbr::FieldAccessorTable internal__static_protobuf_unittest_import_PublicImportMessage__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnittestImportPublicProto3() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvcHJvdG9idWYvdW5pdHRlc3RfaW1wb3J0X3B1YmxpY19wcm90", 
            "bzMucHJvdG8SGHByb3RvYnVmX3VuaXR0ZXN0X2ltcG9ydCIgChNQdWJsaWNJ", 
            "bXBvcnRNZXNzYWdlEgkKAWUYASABKAVCNwoYY29tLmdvb2dsZS5wcm90b2J1", 
          "Zi50ZXN0qgIaR29vZ2xlLlByb3RvYnVmLlRlc3RQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbr::FileDescriptor[] {
          });
      internal__static_protobuf_unittest_import_PublicImportMessage__FieldAccessorTable = 
          new pbr::FieldAccessorTable(typeof(global::Google.Protobuf.TestProtos.PublicImportMessage), descriptor.MessageTypes[0],
              new string[] { "E", }, new string[] { });
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class PublicImportMessage : pb::IMessage<PublicImportMessage> {
    private static readonly pb::MessageParser<PublicImportMessage> _parser = new pb::MessageParser<PublicImportMessage>(() => new PublicImportMessage());
    public static pb::MessageParser<PublicImportMessage> Parser { get { return _parser; } }

    private static readonly string[] _fieldNames = new string[] { "e" };
    private static readonly uint[] _fieldTags = new uint[] { 8 };
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.TestProtos.UnittestImportPublicProto3.Descriptor.MessageTypes[0]; }
    }

    pbr::FieldAccessorTable pb::IReflectedMessage.Fields {
      get { return global::Google.Protobuf.TestProtos.UnittestImportPublicProto3.internal__static_protobuf_unittest_import_PublicImportMessage__FieldAccessorTable; }
    }

    private bool _frozen = false;
    public bool IsFrozen { get { return _frozen; } }

    public PublicImportMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    public PublicImportMessage(PublicImportMessage other) : this() {
      e_ = other.e_;
    }

    public PublicImportMessage Clone() {
      return new PublicImportMessage(this);
    }

    public void Freeze() {
      if (IsFrozen) {
        return;
      }
      _frozen = true;
    }

    public const int EFieldNumber = 1;
    private int e_;
    public int E {
      get { return e_; }
      set {
        pb::Freezable.CheckMutable(this);
        e_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as PublicImportMessage);
    }

    public bool Equals(PublicImportMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (E != other.E) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (E != 0) hash ^= E.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (E != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(E);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (E != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(E);
      }
      return size;
    }

    public void MergeFrom(PublicImportMessage other) {
      if (other == null) {
        return;
      }
      if (other.E != 0) {
        E = other.E;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while (input.ReadTag(out tag)) {
        switch(tag) {
          case 0:
            throw pb::InvalidProtocolBufferException.InvalidTag();
          default:
            if (pb::WireFormat.IsEndGroupTag(tag)) {
              return;
            }
            break;
          case 8: {
            E = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
