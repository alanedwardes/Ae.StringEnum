using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ae.StringEnum
{
    public sealed class StringEnumConverterFactory : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert) => typeof(StringEnum).IsAssignableFrom(typeToConvert);

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            return Activator.CreateInstance(typeof(StringEnumConverter<>).MakeGenericType(typeToConvert)) as JsonConverter;
        }
    }
}
