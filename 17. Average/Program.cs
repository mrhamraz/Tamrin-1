using System;

namespace _17._Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 numbers to calculate the average :");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The aevrage is : " + (num1 + num2 + num3 + num4)/4 );

            /*
             //average of any inputs:
            int size;
            Console.WriteLine("Enter the quantity of numbers :");
            size = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[size];

            Console.WriteLine("Enter the numbers (Elements of the Array) : ");

            for (int i = 0; i < size; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            float sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("Sum Of Array is : " + sum);
            Console.WriteLine("Average Of Array is : " + (sum / size));
            */
        }
    }
}
