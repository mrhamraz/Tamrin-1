using System;

namespace _15._Power_3_of_an_input
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter a number to calculate power 3 of it: ");

            int basenum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(basenum + "^3 = " + (basenum * basenum * basenum));
            */

            Console.WriteLine("Enter base number : ");
            int basenum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter exponent : ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            int power = 1;
            int i;

            if (basenum == 0 && exponent == 0)
            {
                Console.WriteLine("Math Error...");
            }
            else
            { 
                for (i = 1; i <= exponent; i++)
                    power = basenum * power;

                Console.WriteLine(power);
            }
            
                
            

        }
    }
}
