using System;

namespace _10._Print_ascii_value_of_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character: ");
            string c = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ASCII Value of " + c + " is " + Convert.ToInt32(c));

        }
    }
}
