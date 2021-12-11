namespace Ae.StringEnum.Test
{
    public sealed class TestStringEnum : StringEnum<TestStringEnum>
    {
        public static readonly TestStringEnum WIBBLE = new("WIBBLE");

        public TestStringEnum(string value) : base(value)
        {
        }
    }
}
