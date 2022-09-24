using System;

namespace InputOutput
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string myName = Console.ReadLine();
            Console.WriteLine("Hello " + myName);
        }
    }
}

