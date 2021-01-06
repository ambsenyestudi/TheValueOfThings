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
    }
}
