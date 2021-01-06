using System;

namespace TheValueOfThings.Domain
{
    public class SingleValueObject<T> where T : class
    {
        public T Value { get; }
        public SingleValueObject(T value, string nullMessage = "Value object cannot be null")
        {
            if (value == null)
            {
                throw new ArgumentException(nullMessage);
            }
            Value = value;
        }
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var other = obj as SingleValueObject<T>;
            if (other == null)
            {
                return false;
            }
            return Value == other.Value;
        }

        public static bool operator ==(SingleValueObject<T> x, SingleValueObject<T> y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }

            if (((object)x == null) || ((object)y == null))
            {
                return false;
            }

            return x.Equals(y);
        }

        public static bool operator !=(SingleValueObject<T> x, SingleValueObject<T> y)
        {
            return !(x == y);
        }
    }
}
