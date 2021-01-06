using System;
using TheValueOfThings.Domain.Languages;

namespace TheValueOfThings.Application.Languages
{
    public class LanguageService : ILanguageService
    {
        public string Translate(OrigionalIso origionalIso, TranslationIso translationIso, string word)
        {
            var from = origionalIso as Iso;
            var to = translationIso as Iso;
            if(from == to)
            {
                return word;
            }
            return null;
        }
    }
}
