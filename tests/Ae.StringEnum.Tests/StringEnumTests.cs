using Xunit;

namespace Ae.StringEnum.Test
{
    public sealed class StringEnumTests
    {
        [Fact]
        public void TestObjectEquality()
        {
            Assert.True(((object)TestStringEnum.WIBBLE).Equals(new TestStringEnum("WIBBLE")));
            Assert.False(((object)TestStringEnum.WIBBLE).Equals(new TestStringEnum("test")));
        }

        [Fact]
        public void TestTypedEquality()
        {
            Assert.True(TestStringEnum.WIBBLE.Equals(new TestStringEnum("WIBBLE")));
            Assert.False(TestStringEnum.WIBBLE.Equals(new TestStringEnum("test")));
        }

        [Fact]
        public void TestOperatorEquality()
        {
            Assert.True(TestStringEnum.WIBBLE == new TestStringEnum("WIBBLE"));
            Assert.True(TestStringEnum.WIBBLE != new TestStringEnum("test"));
        }
    }
}
