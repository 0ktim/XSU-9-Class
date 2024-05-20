namespace Array._15._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}
