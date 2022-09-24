// See https://aka.ms/new-console-template for more information
using System;

double length;
double width;
double area;

Console.WriteLine("Enter length:");
string input = Console.ReadLine();
length = double.Parse(input);
Console.WriteLine("Enter width:");
input = Console.ReadLine();
width = double.Parse(input);

area = length * width;
Console.WriteLine("You rectangle area is " + area);

