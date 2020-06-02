using System;

namespace Studio__Area_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + area);
            Console.WriteLine("The circumfrence of a circle of radius " + radius + " is: " + (2 * Math.PI * radius));
            Console.WriteLine("The diameter of a circle of radius " + radius + " is: " + (2 * radius));

            Console.WriteLine("How many MPG does your car get");
            double mpg = double.Parse(Console.ReadLine());
            Console.WriteLine("Your car will use " + ((2 * radius)/mpg) + " gallons to go around the circle");



        }
    }
}
