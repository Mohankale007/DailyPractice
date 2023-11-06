using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheitConversion
{
    internal class Conversion
    {
        public double FahrenheitToCelsius(string fahrenheit)
        {    //°C = (°F − 32) x 5/9
            double fara=double.Parse(fahrenheit);
            double result = (fara - 32) * 5 / 9;
            return result;
        }
        public double CelsiusToFahrenheit(string Celsius)
        {    //°F = (°C × 9/5) + 32
            double cel = double.Parse(Celsius);
            double result = (cel *9/5) +32;
            return result;
        }
    }
}
