using System;

namespace _3_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that read from the console the radius "r" of a circle
            //and prints its perimeter and area.
            Cicle();
        }

        public static void Cicle()
        {
            Console.Write("radius = ");
            int r = int.Parse(Console.ReadLine());

            double p = 2 * Math.PI * r;
            double a = Math.PI * Math.Pow(r, 2);

            Console.WriteLine("Perimeter = " + p);
            Console.WriteLine("Area = " + a);
        }

    }
}
