using System;

namespace TheValueOfThings.Domain.Languages
{
    public class TranslationIso : Iso
    {
        public TranslationIso(string iso) : base(iso)
        {
            if (string.IsNullOrWhiteSpace(iso))
            {
                throw new ArgumentException("Iso can not be empty");
            }
        }
    }
}
