using System;

namespace _16._Multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to display the mutipications table from 0 to 10: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            while (i <= 10) 
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, (num * i));
                i++;
            }
        }
    }
}
