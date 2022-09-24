using System;

namespace AreaCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a radius: ");
            double r = double.Parse(Console.ReadLine());
            //area
            double a = Math.PI * Math.Pow(r, 2);
            //circumference
            double c = 2 * Math.PI * r;
            //diameter
            double d = 2 * r;

            Console.WriteLine("The area of a circle of radius " + r + " is: " + a);
            Console.WriteLine("Circumference is: " + c);
            Console.WriteLine("Diameter is: " + d);

        }
    }
}
