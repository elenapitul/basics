using System;

namespace _10_TriangleStar
{
    class Program
    {
        static void Main(string[] args)
        {
            //10. Write a program that outputs  triangle made of stars with variable size, depending on an input parameter.
            //Look at the examples to get an idea. The input comes as a string number, which needs to be parsed to a number.
            //The output is a series of lines printed on the console, forming a triangle of variable size.

            Console.WriteLine("Please input a number");
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = input; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }




        }
    }
}
