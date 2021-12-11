using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Ae.StringEnum.Test
{
    public sealed class TestContract1
    {
        [JsonPropertyName("test1")]
        public TestStringEnum Test1 { get; set; }
        [JsonPropertyName("test2")]
        public IList<TestStringEnum> Test2 { get; set; }
        [JsonPropertyName("test3")]
        public IDictionary<string, TestStringEnum> Test3 { get; set; }
    }
}
