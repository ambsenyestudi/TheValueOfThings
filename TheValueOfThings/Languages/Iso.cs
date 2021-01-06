using System;

namespace TheValueOfThings.Languages
{
    public class Iso
    {
        public string Value { get; }
        public Iso(string iso)
        {
            if(string.IsNullOrWhiteSpace(iso))
            {
                throw new ArgumentException(iso);
            }
            Value = iso;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var other = obj as Iso;
            if(other == null)
            {
                return false;
            }
            return Value == other.Value;
        }
    }
}
