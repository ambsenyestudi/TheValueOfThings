using System;

namespace TheValueOfThings.Domain.Languages
{
    public class OrigionalIso : Iso
    {
        public OrigionalIso(string iso) : base(iso)
        {
            if (string.IsNullOrWhiteSpace(iso))
            {
                throw new ArgumentException("Iso can not be empty");
            }
        }
    }
}
