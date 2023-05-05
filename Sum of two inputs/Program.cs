using System;

namespace Sum_of_two_inputs
{
    class Program
    {
        static void Main(string[] args)
        {
            /* My code :
   
            Console.WriteLine("Hello, This programe will make a sum 0f 2 inputs");
            Console.WriteLine("Enter Num 1 :");
            string num1 = Console.ReadLine();

            Console.WriteLine("Now enter Num 2 :");
            String num2 = Console.ReadLine();

            int Num1 = Convert.ToInt32(num1);
            int Num2 = Convert.ToInt32(num2);

            int sum = Num1 + Num2;

            Console.WriteLine("Now the sum is : " + sum);
            */

            // code from internet: 

            Console.Write("Enter two numbers: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of two numbers is : {0} ", (number1 + number2));
            //Console.WriteLine("The sum of two numbers is : " + (number1 + number2));
        }
    }
}