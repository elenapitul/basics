using System;

namespace _2_GreatestOfFive
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Write a program that reads five numbers from the console 
            //and prints the greatest of them.

            Greatest();
            Greatest_2();

        }

        public static void Greatest()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("e = ");
            int e = int.Parse(Console.ReadLine());

            int max_ab = Math.Max(a, b);
            int max_cd = Math.Max(c, d);
            int max_abcd = Math.Max(max_ab, max_cd);
            int max = Math.Max(max_abcd, e);

            Console.WriteLine("max = " + max);

        }

        public static void Greatest_2()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("e = ");
            int e = int.Parse(Console.ReadLine());

            if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
            {
                Console.WriteLine("max = " + a);
            }
            else if ((b >= c) && (b >= d) && (b >= e))
            {
                Console.WriteLine("max =" + b);
            }
            else if ((c >= d) && (c >= e))
            {
                Console.WriteLine("max = " + c);
            }
            else if (d >= e)
            {
                Console.WriteLine("max =" + d);
            }
            else Console.WriteLine("max = " + e);

        }
    }
}
