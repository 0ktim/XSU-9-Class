namespace Ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int sum = 0;

            foreach (var i in numbers)
            {
                sum += i;
            }
                Console.WriteLine(sum);
        }
    }
}
