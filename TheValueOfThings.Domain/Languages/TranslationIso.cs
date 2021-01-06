using System;

namespace TheValueOfThings.Domain.Languages
{
    public class TranslationIso : Iso
    {
        private TranslationIso(string iso) : base(iso)
        {
            if (string.IsNullOrWhiteSpace(iso))
            {
                throw new ArgumentException("Iso can not be empty");
            }
        }
        public static TranslationIso CreateTranslationIso(string iso, IIsoService isoService)
        {
            if (!isoService.IsValidIso(iso))
            {
                throw new ArgumentException(INVALID_ISO_ERROR);
            }
            return new TranslationIso(iso);
        }
    }
}
