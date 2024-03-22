namespace _21._03._241
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            bool proverka = true;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    proverka = false;
                    break;
                }
            }
            if (proverka)
            {
                Console.WriteLine("Sorted!");
            }
            else
            {
                Console.WriteLine("Unsorted!");
            }







        }
    }
}
