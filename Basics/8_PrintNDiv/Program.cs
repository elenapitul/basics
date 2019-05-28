using System;

namespace _8_PrintNotDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            //8. Write a program that prints on the console the numbers from 1 to N, 
            //which are NOT divisible by 3 AND 7, simultaneously.
            //The number N should be read from the standard input.

            int n;
            bool isNumber = false;

            do
            {
                Console.Write("n = ");
                isNumber = int.TryParse(Console.In.ReadLine(), out n);              
            } while (!isNumber);

            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 != 0) && (i % 7 != 0))
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
