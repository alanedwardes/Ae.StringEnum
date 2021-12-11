using System.Collections.Generic;
using System.Text.Json;
using Xunit;

namespace Ae.StringEnum.Test
{
    public sealed class SerializationTests
    {
        private static readonly JsonSerializerOptions _serializerOptions = new() { Converters = { new StringEnumConverterFactory() } };

        [Fact]
        public void TestReadJsonNull()
        {
            var result = JsonSerializer.Deserialize<TestContract1>("{}", _serializerOptions);
            Assert.Null(result.Test1);
            Assert.Null(result.Test2);
            Assert.Null(result.Test3);
        }

        [Fact]
        public void TestReadJsonValues()
        {
            var result = JsonSerializer.Deserialize<TestContract1>("{\"test1\":\"WIBBLE\",\"test2\":[\"WIBBLE\"],\"test3\":{\"test4\":\"WIBBLE\"}}", _serializerOptions);
            Assert.Equal(TestStringEnum.WIBBLE, result.Test1);
            Assert.Equal(new[] { TestStringEnum.WIBBLE }, result.Test2);
            Assert.Equal(new Dictionary<string, TestStringEnum> { { "test4", TestStringEnum.WIBBLE } }, result.Test3);
        }

        [Fact]
        public void TestWriteJsonValues()
        {
            var contract = new TestContract1
            {
                Test1 = TestStringEnum.WIBBLE,
                Test2 = new[] { TestStringEnum.WIBBLE, new TestStringEnum("test") },
                Test3 = new Dictionary<string, TestStringEnum> { { "test", TestStringEnum.WIBBLE } }
            };

            var result = JsonSerializer.Serialize(contract, _serializerOptions);
            Assert.Equal("{\"test1\":\"WIBBLE\",\"test2\":[\"WIBBLE\",\"test\"],\"test3\":{\"test\":\"WIBBLE\"}}", result);
        }
    }
}
