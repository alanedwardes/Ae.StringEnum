using System;

namespace Ae.StringEnum
{
    public abstract class StringEnum<TStringEnum> : StringEnum, IEquatable<TStringEnum>
        where TStringEnum : StringEnum
    {
        public StringEnum(string value) : base(value)
        {
        }

        public bool Equals(TStringEnum? other) => Equals(other as object);
    }
}
