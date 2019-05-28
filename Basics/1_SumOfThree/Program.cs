using System;

namespace _1_SumOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Write a program that reads from the console 
            //three numbers of type int and prints their sum.
            SumOfThree();
        }

        public static void SumOfThree()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            int sum = a + b + c;
            Console.WriteLine("sum = " + sum);
            
        }

    }
}
