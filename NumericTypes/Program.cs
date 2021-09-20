using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLength;
            double length;
            string inputWidth;
            double width;

            Console.WriteLine("What is the rectangle's length?");
            inputLength = Console.ReadLine();
            length = double.Parse(inputLength);
            Console.WriteLine("What is the rectangle's width?");
            inputWidth = Console.ReadLine();
            width = double.Parse(inputWidth);
            double area = length * width;
            Console.WriteLine("The area of the rectangle is " + area + ".");
        }
    }
}
