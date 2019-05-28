using System;

namespace _9_SmallLarge
{
    class Program
    {
        static void Main(string[] args)
        {
            //9. Write a program that reads from the console a series of 5 integers
            //and prints the smallest and largest of them.

            SmallLarge();

        }

        public static void SmallLarge()
        {
            int a, b, c, d, e;
            bool isNumber = false;

            do
            {
                Console.Write("a = ");
                isNumber = int.TryParse(Console.In.ReadLine(), out a);

                Console.Write("b = ");
                isNumber = int.TryParse(Console.In.ReadLine(), out b);

                Console.Write("c = ");
                isNumber = int.TryParse(Console.In.ReadLine(), out c);

                Console.Write("d = ");
                isNumber = int.TryParse(Console.In.ReadLine(), out d);

                Console.Write("e = ");
                isNumber = int.TryParse(Console.In.ReadLine(), out e);
            } while (!isNumber);

            Console.WriteLine("The smallest number is " + Min(a, b, c, d, e));
            Console.WriteLine("The largest number is " + Max(a, b, c ,d ,e));


        }

        public static int Max(int a, int b, int c, int d, int e)
        {
            return Math.Max(a, Math.Max(b, Math.Max(c, Math.Max(d, e))));
        }

        public static int Min(int a, int b, int c, int d, int e)
        {
            return Math.Min(a, Math.Min(b, Math.Min(c, Math.Min(d, e))));
        }
    }
}
