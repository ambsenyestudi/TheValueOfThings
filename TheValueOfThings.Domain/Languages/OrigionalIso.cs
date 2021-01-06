using System;

namespace TheValueOfThings.Domain.Languages
{
    public class OrigionalIso : Iso
    {
        private OrigionalIso(string iso) : base(iso)
        {
        }

        public static OrigionalIso CreateOrigionalIso(string iso, IIsoService isoService)
        {
            if (!isoService.IsValidIso(iso))
            {
                throw new ArgumentException(INVALID_ISO_ERROR);
            }
            return new OrigionalIso(iso);
        }
    }
}
