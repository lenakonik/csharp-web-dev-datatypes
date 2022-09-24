using System;

namespace ModularWhileConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = 0;
            while (r <= 0)
            {
                Console.Write("Enter a radius in miles: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out _))
                {
                    r = double.Parse(input);
                }
                else
                {
                    Console.WriteLine("Invalid radius");
                    //Environment.Exit(0);
                }

            }

            double mpg = 0;
            while (mpg <= 0)
            {
                Console.Write("Enter miles per gallon of your car: ");
                mpg = double.Parse(Console.ReadLine());
            }

            // Create a circle with this radius
            Circle myRoute = new Circle(r);
      
            // Print how many gallons of gas they will use to go around this circle
            Console.WriteLine("You will use " + myRoute.fuel(mpg) + " gallons of gas to go around the circle with this radius.");
        }
    }
}
