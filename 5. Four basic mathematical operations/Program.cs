using System;

namespace _5._Four_basic_mathematical_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, This programe will answer of four basic mathematical operations (+ - * /) 0f 2 inputs");
            Console.WriteLine("Enter Num 1 :");
            string Num1 = Console.ReadLine();

            Console.WriteLine("Now enter Num 2 :");
            String Num2 = Console.ReadLine();

            double num1 = Convert.ToInt32(Num1);
            double num2 = Convert.ToInt32(Num2);

            Console.WriteLine("Answers :");
            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            Console.WriteLine(num2 + " - " + num1 + " = " + (num2 - num1));
            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
            Console.WriteLine(num2 + " / " + num1 + " = " + (num2 / num1));
        }
    }
}
