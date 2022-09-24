namespace TempConv
{
    class Program
    {
        public static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            string input;

            System.Console.WriteLine("Temperature in F:");
            input = System.Console.ReadLine();
            fahrenheit = double.Parse(input);

            celsius = (fahrenheit - 32) * 5 / 9;
            System.Console.WriteLine("The Temperature in C is: " + celsius);
            System.Console.ReadLine();
        }
    }
}
