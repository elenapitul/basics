using System;

namespace _13_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //13. A program which iterates the integers from 1 to 50.
            //For multiples of 3 print "Fizz" instead of the number and for the multiples of five print "Buzz".
            //For numbers which are multiples of both three and five print "FizzBuzz".

            for (int i = 1; i <= 50; i++)
            {
                if ((i % 3 == 0) && (i % 5 != 0))
                {
                    Console.WriteLine("Fizz");
                } else if ((i % 3 != 0) && (i % 5 == 0))
                {
                    Console.WriteLine("Buzz");
                } else if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else Console.WriteLine(i);
            }
        }
    }
}
