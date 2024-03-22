namespace _14._03._242
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 17, 25, 34, 43, 59 };
            int max = nums[0];
            foreach (int num in nums) 
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);

        }
    }
}
