namespace CelsiusToFahrenheitConversion
{

// Multiply the °C temperature by 1.8. Add 32 to this number.This is the answer in °F.
// °F = (°C × 9/5) + 32
//It's just as easy to convert Fahrenheit to Celcius;
//°C = (°F − 32) x 5/9
    internal class Program
    {
        static void Main(string[] args)
        {

            Conversion conversion = new Conversion();
            Console.WriteLine("Enter Fahrenheit Value in F:");
            string val1=Console.ReadLine();
            double result1= conversion.FahrenheitToCelsius(val1);
            Console.WriteLine(result1+" C");

            Console.WriteLine("Enter Celsius Value in C");
            string val2=Console.ReadLine();
            double result2 = conversion.CelsiusToFahrenheit(val2);
            Console.WriteLine(result2+" F");
            Console.ReadLine();
            
        }
    }
}