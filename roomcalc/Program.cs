using System;

namespace roomcalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Room Calculator!");
            Console.WriteLine("Please enter a length");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a width");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a height");
            double height = double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = (length + width) * 2;
            double volume = length * width * height;

            Console.WriteLine("The area of the room is " + area);
            Console.WriteLine("The perimeter of the room is " + perimeter);
            Console.WriteLine("The volume of the room is " + volume);
            Console.WriteLine("The surface area of the room is " + 2 * ((length * width) + (length * height) + (height * width)));

            Console.WriteLine("Thank you for using the Room Calculator!");
        }
    }
}
