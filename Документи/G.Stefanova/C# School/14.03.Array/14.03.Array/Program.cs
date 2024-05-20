namespace _14._03.Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6};
            foreach (var item in numbers)
            {
                Console.WriteLine(numbers[item]);
            }
        }
    }
}
