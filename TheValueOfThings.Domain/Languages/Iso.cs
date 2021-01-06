using System;

namespace TheValueOfThings.Domain.Languages
{
    public class Iso : SingleValueObject<string>
    {
        public const string ISO_EMPTY_ERROR = "Iso can not be empty";
        public const string INVALID_ISO_ERROR = "Invalid Iso";
        protected Iso(string iso) : base(iso)
        {
            if (string.IsNullOrWhiteSpace(iso))
            {
                throw new ArgumentException(ISO_EMPTY_ERROR);
            }
        }
        public static Iso CreateIso(string iso, IIsoService isoService)
        {
            if(!isoService.IsValidIso(iso))
            {
                throw new ArgumentException(INVALID_ISO_ERROR);
            }
            return new Iso(iso);
        }
    }
}
