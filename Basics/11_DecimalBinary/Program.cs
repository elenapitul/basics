using System;

namespace _11_DecimalBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            //11. Write a program that converts a given number from decimal to binary notation (numeral system).

            Console.WriteLine("Decimal number is: ");
            decimal deciNumber = decimal.Parse(Console.ReadLine());
            int intNumber = Decimal.ToInt32(deciNumber);

            int remainder;

            string binary = string.Empty;

            do
            {
                remainder = intNumber % 2;
                intNumber /= 2;
                binary = remainder.ToString() + binary;

            } while (intNumber > 0);

            Console.WriteLine($"Binary number is: {binary}");
        }
    }
}
