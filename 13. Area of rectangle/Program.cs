using System;

namespace _13._Area_of_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length ond width of rectangle :");
            int l = Convert.ToInt32(Console.ReadLine());
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of rectangle is :" + (l * w));
        }
    }
}
