using System;

namespace _6._Convert_Metre_to_Centimetre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, This programe will convert Metre to Centimetre...");
            Console.WriteLine("Enter a number in Metre :");

            string Metre = Console.ReadLine();

            double metre = Convert.ToDouble(Metre);

            double cent = metre * 100;

            Console.WriteLine("So " + metre + "m is " + cent + "c");
        }
    }
}
