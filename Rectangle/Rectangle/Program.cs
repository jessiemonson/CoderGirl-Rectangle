using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
                int length, width, area;

            Console.Write("Enter the length of the rectangle: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            width = Convert.ToInt32(Console.ReadLine());
            area = length * width;
            
            Console.WriteLine($"Area is: {area}");



            Console.ReadKey();
        }
    }
}
