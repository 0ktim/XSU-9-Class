namespace Ex._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            Array.Reverse(numbers);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
