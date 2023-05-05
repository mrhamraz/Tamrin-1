using System;

namespace _8._Convert_Fahrenheit_to_Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, This programe will convert Fahrenheit to Celsius...");
            Console.WriteLine("Enter a number in °F :");

            string F = Console.ReadLine();

            double f = Convert.ToDouble(F);

            double c = (f - 32) * 5 / 9;

            Console.WriteLine("So " + f + "°F is " + c + "°C");
        }
    }
}
