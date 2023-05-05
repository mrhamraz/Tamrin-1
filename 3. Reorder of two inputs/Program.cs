using System;

namespace Reorder_of_two_inputs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, This programe will replace the order of 2 inputs");
            Console.WriteLine("Enter Num 1 :");
            string num1 = Console.ReadLine();

            Console.WriteLine("Now enter Num 2 :");
            String num2 = Console.ReadLine();

            int Num1 = Convert.ToInt32(num1);
            int Num2 = Convert.ToInt32(num2);

            int num3 = Num1;
            Num1 = Num2;
            Num2 = num3;

            Console.WriteLine("Now we changed the order and the result is: " + Num1 + " - " + Num2);


        }
    }
}
