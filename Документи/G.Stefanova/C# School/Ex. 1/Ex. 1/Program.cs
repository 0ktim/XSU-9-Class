namespace Ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 6, 8, 10 };
            int nums = numbers.Length;
            double sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }
            Console.WriteLine(sum / nums);
        }
    }
}
