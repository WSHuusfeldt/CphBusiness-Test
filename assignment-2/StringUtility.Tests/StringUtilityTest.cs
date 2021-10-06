using System;
using Xunit;

namespace StringUtility.Tests
{
    public class StringUtilityTest
    {

        private readonly StringUtility _stringUtility;

        public StringUtilityTest()
        {
            _stringUtility = new StringUtility();
        }

        [Theory]
        [InlineData("ABc", "abc")]
        [InlineData("fAO", "fao")]
        [InlineData("ÆPSddD", "æpsddd")]
        public void ToLowercaseTest(string before, string after)
        {
            StringUtility su = new StringUtility();
            Assert.Equal(after, su.ToLowercase(before));
        }

        [Theory]
        [InlineData("åqf", "ÅQF")]
        [InlineData("WsD", "WSD")]
        [InlineData("mdHklæÆ", "MDHKLÆÆ")]
        public void ToUppercaseTest(string before, string after)
        {
            StringUtility su = new StringUtility();
            Assert.Equal(after, su.ToUppercase(before));
        }

        [Theory]
        [InlineData("abc", "cba")]
        [InlineData("hgDE", "EDgh")]
        [InlineData("toT", "Tot")]
        public void ReverseTest(string before, string after)
        {
            StringUtility su = new StringUtility();
            Assert.Equal(after, su.ReverseString(before));
        }
    }
}
