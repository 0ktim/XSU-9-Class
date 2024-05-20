namespace Ex._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int maxNum = 0;

            foreach (var item in numbers)
            {
                if (item > maxNum)
                {
                    maxNum = item;
                }
            }
                Console.WriteLine(maxNum);
        }
    }
}
