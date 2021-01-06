using Moq;
using System.Collections.Generic;
using TheValueOfThings.Domain.Languages;

namespace TheValueOfThings.Test.Languages
{
    public class IsoServiceBuilder
    {
        private readonly Mock<IIsoService> isoServiceMock;
        private List<string> validLanguages;

        public IsoServiceBuilder()
        {
            isoServiceMock = new Mock<IIsoService>();
        }
        public IsoServiceBuilder WithValidLanguage(List<string> validLanguages)
        {
            this.validLanguages = validLanguages;
            return this;
        }
        public IIsoService Build()
        {
            isoServiceMock
                .Setup(x => x.IsValidIso(It.IsAny<string>()))
                .Returns((string iso) => validLanguages.Contains(iso));
            return isoServiceMock.Object;
        }
    }
}
