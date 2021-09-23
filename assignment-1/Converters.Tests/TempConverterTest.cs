using System;
using Xunit;

namespace Converters.Tests
{
    public class TempConverterTest
    {

        private readonly TempConverter _tempConverter;

        public TempConverterTest(){
            _tempConverter = new TempConverter();
        }

        [Theory]
        [InlineData(100, 212)]
        [InlineData(34, 93.2)]
        [InlineData(50, 122)]
        public void CToFTheory(double celcius, double fahrenheit) {
            TempConverter conv = new TempConverter();
            double actual = conv.CelciusToFahrenheit(celcius);
            Assert.Equal(fahrenheit, actual);
        }

        [Theory]
        [InlineData(100, 37.77777777777778)]
        [InlineData(76, 24.444444444444443)]
        [InlineData(32, 0)]
        public void FToCTheory(double fahrenheit, double celcius) {
            TempConverter conv = new TempConverter();
            double actual = conv.FahrenheitToCelcius(fahrenheit);
            Assert.Equal(celcius, actual);
        }

    }
}
