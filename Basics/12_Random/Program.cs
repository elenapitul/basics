using System;

namespace _12_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            //12. Write a program that by a given N prints the numbers from 1 to N in random order.

            Random rndm = new Random();
            int aux;
            int randomNumber;

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 1; i < array.Length; i++)
            {
                array[i] = i;
            }

            foreach(int element in array)
            {
                randomNumber = rndm.Next(1, n);
                aux = array[element];
                array[element] = array[randomNumber];
                array[randomNumber] = aux;
            }

            foreach(int element in array)
            {
                Console.WriteLine(array[element]);
            }

        }
    }
}
