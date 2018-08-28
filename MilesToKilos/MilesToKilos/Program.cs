using System;

namespace MilesToKilos
{
    class Program
    {
        static void Main(string[] args)
        {
            const double kilos = 1.6;
            Console.Write("Please enter distance in miles: ");
            double miles = Convert.ToDouble(Console.ReadLine());
            double result = miles * kilos;
            Console.WriteLine(miles + " miles is " + result + " kilometers.");
            Console.ReadLine();
        }
    }
}
