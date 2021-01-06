using TheValueOfThings.Application.Languages;
using TheValueOfThings.Domain.Languages;
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
            var original = new OrigionalIso("en");
            var translation = new TranslationIso("en");
            var actual = sut.Translate(original, translation, expected);
            Assert.Equal(expected, actual);
        }
    }
}
