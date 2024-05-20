using System.Buffers;

namespace Ex._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 4, 8, 3, 5, 1 };
            Array.Sort(numbers);
            Array.Reverse(numbers);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
