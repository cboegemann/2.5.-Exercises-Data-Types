using System;

namespace MoreOnNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputMiles;
            double miles;
            string inputGas;
            double gas;

            Console.WriteLine("How many miles have you driven?");
            inputMiles = Console.ReadLine();
            miles = double.Parse(inputMiles);
            Console.WriteLine("How much gas did you use?");
            inputGas = Console.ReadLine();
            gas = double.Parse(inputGas);
            double milesPerGallon = miles / gas;
            Console.WriteLine("Your miles-per-gallon is " + milesPerGallon + ".");
        }
    }
}
