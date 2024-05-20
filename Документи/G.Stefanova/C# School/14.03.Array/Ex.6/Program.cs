namespace Ex._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -1, 2, -3, 4, -5, 6 };
            int countNegativeNum = 0;

            foreach (var item in numbers)
            {
                if (item < 0)
                {
                    countNegativeNum++;
                }
            }
                    Console.WriteLine(countNegativeNum);

            
        }
    }
}
