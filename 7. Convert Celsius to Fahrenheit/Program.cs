using System;

namespace _7._Convert_Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, This programe will convert Celsius to Fahrenheit...");
            Console.WriteLine("Enter a number in °C :");

            string C = Console.ReadLine();

            double c = Convert.ToDouble(C);

            double f = (c * 9/5) + 32;

            Console.WriteLine("So " + c + "°C is " + f + "°F");
        }
    }
}
