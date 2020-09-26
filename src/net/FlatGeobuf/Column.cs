// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatGeobuf
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct Column : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static Column GetRootAsColumn(ByteBuffer _bb) { return GetRootAsColumn(_bb, new Column()); }
  public static Column GetRootAsColumn(ByteBuffer _bb, Column obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Column __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public FlatGeobuf.ColumnType Type { get { int o = __p.__offset(6); return o != 0 ? (FlatGeobuf.ColumnType)__p.bb.Get(o + __p.bb_pos) : FlatGeobuf.ColumnType.Byte; } }
  public string Title { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTitleBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetTitleBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetTitleArray() { return __p.__vector_as_array<byte>(8); }
  public string Description { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetDescriptionBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetDescriptionArray() { return __p.__vector_as_array<byte>(10); }
  public int Width { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)-1; } }
  public int Precision { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)-1; } }
  public int Scale { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)-1; } }
  public bool Nullable { get { int o = __p.__offset(18); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)true; } }
  public bool Unique { get { int o = __p.__offset(20); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool PrimaryKey { get { int o = __p.__offset(22); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string Metadata { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMetadataBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetMetadataBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetMetadataArray() { return __p.__vector_as_array<byte>(24); }

  public static Offset<FlatGeobuf.Column> CreateColumn(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      FlatGeobuf.ColumnType type = FlatGeobuf.ColumnType.Byte,
      StringOffset titleOffset = default(StringOffset),
      StringOffset descriptionOffset = default(StringOffset),
      int width = -1,
      int precision = -1,
      int scale = -1,
      bool nullable = true,
      bool unique = false,
      bool primary_key = false,
      StringOffset metadataOffset = default(StringOffset)) {
    builder.StartTable(11);
    Column.AddMetadata(builder, metadataOffset);
    Column.AddScale(builder, scale);
    Column.AddPrecision(builder, precision);
    Column.AddWidth(builder, width);
    Column.AddDescription(builder, descriptionOffset);
    Column.AddTitle(builder, titleOffset);
    Column.AddName(builder, nameOffset);
    Column.AddPrimaryKey(builder, primary_key);
    Column.AddUnique(builder, unique);
    Column.AddNullable(builder, nullable);
    Column.AddType(builder, type);
    return Column.EndColumn(builder);
  }

  public static void StartColumn(FlatBufferBuilder builder) { builder.StartTable(11); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, FlatGeobuf.ColumnType type) { builder.AddByte(1, (byte)type, 0); }
  public static void AddTitle(FlatBufferBuilder builder, StringOffset titleOffset) { builder.AddOffset(2, titleOffset.Value, 0); }
  public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset) { builder.AddOffset(3, descriptionOffset.Value, 0); }
  public static void AddWidth(FlatBufferBuilder builder, int width) { builder.AddInt(4, width, -1); }
  public static void AddPrecision(FlatBufferBuilder builder, int precision) { builder.AddInt(5, precision, -1); }
  public static void AddScale(FlatBufferBuilder builder, int scale) { builder.AddInt(6, scale, -1); }
  public static void AddNullable(FlatBufferBuilder builder, bool nullable) { builder.AddBool(7, nullable, true); }
  public static void AddUnique(FlatBufferBuilder builder, bool unique) { builder.AddBool(8, unique, false); }
  public static void AddPrimaryKey(FlatBufferBuilder builder, bool primaryKey) { builder.AddBool(9, primaryKey, false); }
  public static void AddMetadata(FlatBufferBuilder builder, StringOffset metadataOffset) { builder.AddOffset(10, metadataOffset.Value, 0); }
  public static Offset<FlatGeobuf.Column> EndColumn(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 4);  // name
    return new Offset<FlatGeobuf.Column>(o);
  }
};


}
