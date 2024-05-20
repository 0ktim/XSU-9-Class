using System;

namespace Ex._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 7, 5, 8, 10, 3 };
            int[] numbers = { 1, 2, 3, 4, 5 };
            bool oxi = true;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    oxi = false;
                    break;
                }
            }

            if (oxi)
                Console.WriteLine("Vqrno");
            else
                Console.WriteLine("Greshno");
        }
    }
}
