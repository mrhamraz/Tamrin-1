using System;

namespace _11._Area_of_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius of circle :");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of circle is :" + (r * r * 3.14));
        }
    }
}
