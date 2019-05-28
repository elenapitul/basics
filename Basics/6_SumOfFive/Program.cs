using System;

namespace _6_SumOfFive
{
    class Program
    {
        static void Main(string[] args)
        {
            //6. Write a program that reads five integer numbers and prints their sum.
            //If an invalid number is entered the program should prompt the user to enter
            //another number (only once).

            int a, b, c, d , e ;
            bool isNumber = false;

            
            do
            {
                Console.Write("a = ");
                isNumber = int.TryParse(Console.ReadLine(), out a);
                Console.WriteLine(isNumber);
            } while (!isNumber);

            do
            {
                Console.Write("b = ");
                isNumber = int.TryParse(Console.ReadLine(), out b);
                Console.WriteLine(isNumber);
            } while (!isNumber) ;

            do
            {
                Console.Write("c = ");
                isNumber = int.TryParse(Console.ReadLine(), out c);
                Console.WriteLine(isNumber);
            } while (!isNumber);
                        
            do
            {
                Console.Write("d = ");
                isNumber = int.TryParse(Console.ReadLine(), out d);
                Console.WriteLine(isNumber);
            } while (!isNumber);
                        
            do
            {
                Console.Write("e = ");
                isNumber = int.TryParse(Console.ReadLine(), out e);
                Console.WriteLine(isNumber);
            } while (!isNumber);

            long sum = a + b + c + d + e;
            Console.WriteLine($"sum = {sum}");
                                 
        }

    }
}
