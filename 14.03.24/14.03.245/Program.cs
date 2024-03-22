namespace _14._03._245
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, -1, -2, -3, -4, -5 };
            int negativeCount = 0;
            foreach (int num in nums) 
            {
                if (num < 0)
                {
                    negativeCount++;
                }
            }
                    Console.WriteLine(negativeCount);


        }
    }
}
