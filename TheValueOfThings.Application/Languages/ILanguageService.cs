using TheValueOfThings.Domain.Languages;

namespace TheValueOfThings.Application.Languages
{
    public interface ILanguageService
    {
        string Translate(OrigionalIso origionalIso, TranslationIso translationIso, string word);
    }
}
