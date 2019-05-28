using System;

namespace _6_PrintN
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. Write a program that prints on the console the numbers from 1 to N.
            //The number N should be read from the standard input.

            int n;
            bool isNumber = false;

            do
            {
                Console.Write("n = ");
                isNumber = int.TryParse(Console.In.ReadLine(), out n);
                Console.WriteLine(isNumber);
            } while (!isNumber);

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
