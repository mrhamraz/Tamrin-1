using System;

namespace _19._z__y_x_____z_y___y_x_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("({0} + {1}) * {2} = {3}", x, y, z, (x + y) * z);
            Console.WriteLine("({0} * {1}) + ({1} * {2}) = {3}", x, y, z, (x * y) + (y * z));
        }
    }
}
