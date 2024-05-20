using System.Collections.Immutable;

namespace Ex._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7};
            Array.Reverse(numbers);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
