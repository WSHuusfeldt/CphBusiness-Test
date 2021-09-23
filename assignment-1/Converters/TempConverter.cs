using System;
using System.Linq;

namespace Converters
{
    public class TempConverter
    {
        public double CelciusToFahrenheit(double celcius) {
            return (celcius * 1.8) + 32;
        }

        public double FahrenheitToCelcius(double fahrenheit) {
            return (fahrenheit - 32) / 1.8;
        }
    }
}