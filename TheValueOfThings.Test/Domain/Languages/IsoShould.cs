using Moq;
using System;
using System.Collections.Generic;
using TheValueOfThings.Domain.Languages;
using TheValueOfThings.Test.Languages;
using Xunit;

namespace TheValueOfThings.Test.Domain.Languages
{
    public class IsoShould
    {
        private readonly IsoServiceBuilder isoServiceBuilder;

        public IsoShould()
        {
            isoServiceBuilder = new IsoServiceBuilder();
        }
        [Fact]
        public void NotBeNull()
        {
            string nullIso = null;
            var isoService = isoServiceBuilder
                .WithValidLanguage(new List<string> { nullIso })
                .Build();
                
            Assert.Throws<ArgumentException>(() => Iso.CreateIso(nullIso, isoService));
        }
        
        [Fact]
        public void NotBeEmpty()
        {
            var emptyIso = " ";
            var isoService = isoServiceBuilder
                .WithValidLanguage(new List<string> { emptyIso })
                .Build();

            Assert.Throws<ArgumentException>(() => Iso.CreateIso(emptyIso, isoService));
        }

        [Fact]
        public void SpotEqualIsoObjects()
        {
            var sameIso = "en";
            var isoService = isoServiceBuilder
                .WithValidLanguage(new List<string> { sameIso })
                .Build();
            var lang = Iso.CreateIso(sameIso, isoService);
            var enLang = Iso.CreateIso(sameIso, isoService);
            Assert.Equal(lang, enLang);
        }
    }
}
