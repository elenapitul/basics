using System;

namespace _5_GreaterOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Write a program that read two numbers from the console and print the greater of them.
            //Solve the problem with/out conditional statements.

            GreatConditional();
            GreatUnconditional();
        }

        public static void GreatConditional()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            if (a >= b)
            {
                Console.WriteLine("The greater is " + a);
            }
            else Console.WriteLine("The greater is " + b);

            Console.WriteLine();
        }

        public static void GreatUnconditional()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            double greater = Math.Max(a, b);
            Console.WriteLine("The greater is " + greater);
        }


    }
}
