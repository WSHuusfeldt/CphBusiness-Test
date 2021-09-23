using System;
using Xunit;

namespace Converters.Tests
{
    public class NumberConverterTests
    {

        private readonly NumberConverter _numberConverter;

        public NumberConverterTests(){
            _numberConverter = new NumberConverter();
        }

        [Theory]
        [InlineData(50, "L")]
        [InlineData(10, "X")]
        [InlineData(4, "IV")]
        [InlineData(55, "LV")]
        [InlineData(784, "DCCLXXXIV")]
        [InlineData(666, "DCLXVI")]
        [InlineData(69, "LXIX")]
        public void RomanTestTheory(int number, string roman)
        {
            NumberConverter romanConverter = new NumberConverter();
            string actual = romanConverter.Convert(number);
            Assert.Equal(roman, actual);
        }
        
    }
}