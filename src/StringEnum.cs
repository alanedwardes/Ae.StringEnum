namespace Ae.StringEnum
{
    public abstract class StringEnum
    {
        internal StringEnum(string value) => Value = value;

        public readonly string Value;

        public override bool Equals(object? obj) => Value.Equals((obj as StringEnum)?.Value);

        public static bool operator ==(StringEnum lhs, StringEnum rhs) => lhs.Equals(rhs);

        public static bool operator !=(StringEnum lhs, StringEnum rhs) => !lhs.Equals(rhs);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value;
    }
}
