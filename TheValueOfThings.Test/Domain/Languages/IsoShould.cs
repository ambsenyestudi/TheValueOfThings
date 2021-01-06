﻿using System;
using TheValueOfThings.Domain.Languages;
using Xunit;

namespace TheValueOfThings.Test.Domain.Languages
{
    public class IsoShould
    {
        [Fact]
        public void NotBeNull()
        {
            Assert.Throws<ArgumentException>(() => new Iso(null));
        }
        
        [Fact]
        public void NotBeEmpty()
        {
            Assert.Throws<ArgumentException>(() => new Iso(" "));
        }

        [Fact]
        public void SpotEqualIsoObjects()
        {
            var lang = new Iso("en");
            var enLang = new Iso("en");
            Assert.Equal(lang, enLang);
        }
    }
}