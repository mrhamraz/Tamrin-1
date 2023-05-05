using System;

namespace _4._Multipe_of_two_inputs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, This programe will multiply the 2 inputs");
            Console.WriteLine("Enter Num 1 :");
            string num1 = Console.ReadLine();

            Console.WriteLine("Now enter Num 2 :");
            String num2 = Console.ReadLine();

            double Num1 = Convert.ToInt32(num1);
            double Num2 = Convert.ToInt32(num2);

            double multi = Num1 * Num2;

            Console.WriteLine("Now the answer is : " + multi);
        }
    }
}
