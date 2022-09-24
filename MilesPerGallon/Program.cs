using System;

namespace MilesPerGallon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("number of miles driven:");
            string input = Console.ReadLine();
            double miles = double.Parse(input);

            Console.WriteLine("amount of gas consumed:");
            input = Console.ReadLine();
            double gas = double.Parse(input);

            double mpg = miles / gas;
            Console.WriteLine("miles-per-gallon: " + mpg);

        }
    }
}
