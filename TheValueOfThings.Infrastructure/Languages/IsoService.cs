using TheValueOfThings.Domain.Languages;

namespace TheValueOfThings.Infrastructure.Languages
{
    public class IsoService : IIsoService
    {
        private readonly IsoRepository isoRepository;

        public IsoService(IsoRepository isoRepository)
        {
            this.isoRepository = isoRepository;
        }
        public bool IsValidIso(string iso) =>
            isoRepository.IsValidIso(iso);
    }
}
