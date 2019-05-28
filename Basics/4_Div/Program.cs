using System;

namespace _4_Div
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console two integer numbers (int)
            //and prints how many numbers between them exist that are divisible by 5.
            DivideFive();

        }

        public static void DivideFive()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            int count = 0;

            if (a > b)
            {
                int aux = b;
                b = a;
                a = aux;
            }
             
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    count += 1;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"In the range ({a}, {b}) there are {count} numbers divisible by 5.");
        }
    }
}
