using System.Collections.Generic;

namespace TheValueOfThings.Infrastructure.Languages
{
    public class InMemoryIsoRepository : IsoRepository
    {
        public List<string> IsoList { get; }
        public InMemoryIsoRepository()
        {
            IsoList = new List<string>
            {
                "en",
                "fr",
                "es"
            };
        }

        public bool IsValidIso(string iso) =>
            IsoList.Contains(iso);
    }
}
