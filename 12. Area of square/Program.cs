using System;

namespace _12._Area_of_square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side of square :");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of square is :" + (s * s));
        }
    }
}
