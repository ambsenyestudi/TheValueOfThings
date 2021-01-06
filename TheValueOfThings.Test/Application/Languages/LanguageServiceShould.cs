using System.Collections.Generic;
using TheValueOfThings.Application.Languages;
using TheValueOfThings.Domain.Languages;
using TheValueOfThings.Test.Languages;
using Xunit;

namespace TheValueOfThings.Test.Application.Languages
{
    public class LanguageServiceShould
    {
        private readonly LanguageService sut;

        public LanguageServiceShould()
        {
            sut = new LanguageService();
        }

        [Fact]
        public void LetWordUnchangedWhenIsSameIso()
        {
            var expected = "Hello";
            var englishIso = "en";
            var isoService = new IsoServiceBuilder().
                WithValidLanguage(new List<string> { englishIso })
                .Build();
            var original = OrigionalIso.CreateOrigionalIso(englishIso, isoService);
            var translation = TranslationIso.CreateTranslationIso(englishIso, isoService);
            var actual = sut.Translate(original, translation, expected);
            Assert.Equal(expected, actual);
        }
    }
}
