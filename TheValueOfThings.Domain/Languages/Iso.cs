using System;

namespace TheValueOfThings.Domain.Languages
{
    public class Iso : SingleValueObject<string>
    {

        public Iso(string iso) : base(iso)
        {
            if (string.IsNullOrWhiteSpace(iso))
            {
                throw new ArgumentException("Iso can not be empty");
            }
        }
    }
}
