﻿using System;
using TheValueOfThings.Languages;
using Xunit;

namespace TheValueOfThings.Test.Languages
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
    }
}
