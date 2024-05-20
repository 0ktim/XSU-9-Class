namespace Ex._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;

            foreach (var item in numbers)
            {
                sum += item;
            }
            double average = sum / numbers.Length;
            Console.WriteLine(average);
        }
    }
}
