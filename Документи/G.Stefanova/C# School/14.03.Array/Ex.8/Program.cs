namespace Ex._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int oddSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddSum += numbers[i];
                }
            }
                Console.WriteLine(oddSum);
        }
    }
}
