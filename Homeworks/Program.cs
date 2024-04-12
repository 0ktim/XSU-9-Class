using System.ComponentModel.DataAnnotations.Schema;

namespace Ex._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] secondNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] array = new int[secondNumbers.Length + firstNumbers.Length];
            Console.Clear();

            for (int i = 0; i < firstNumbers.Length; i++)
            {
                array[i] = firstNumbers[i];
            }
            for (int j = 0; j < secondNumbers.Length; j++)
            {
                array[firstNumbers.Length + j] = secondNumbers[j];
            }
            foreach (var number in array)
            {
                if (number == array.Length)
                    Console.Write($"{number}.");
                else
                    Console.Write($"{number}, ");
            }
        }
    }
}
