using System;

namespace _14._Convert_Days_to_Years_Weeks_and_Days
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter days:");

            int days = Convert.ToInt32(Console.ReadLine());

            /*
            Console.WriteLine((days / 365) + " Years, " + (days / 30) + " Months, " + (days / 7) + " weeks");
            */

            int years = days / 365;

            int months = (days % 365) / 30;

            int weeks = ((days % 365) % 30) / 7;

            Console.WriteLine(years + " Years, " + months + " Months, " + weeks + " weeks");

        }
    }
}
