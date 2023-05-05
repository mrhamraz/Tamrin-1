using System;

namespace _18._Replace_Lowercase_characters_by_uppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the character : ");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("The uppercase is : " + (char.ToUpper(ch)));
        }
    }
}
