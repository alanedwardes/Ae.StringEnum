using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ae.StringEnum
{
    public sealed class StringEnumConverter<TStringEnum> : JsonConverter<TStringEnum> where TStringEnum : StringEnum<TStringEnum>
    {
        public override TStringEnum? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Activator.CreateInstance(typeToConvert, new object?[] { reader.GetString() }) as TStringEnum;
        }

        public override void Write(Utf8JsonWriter writer, TStringEnum value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Value);
        }
    }
}
