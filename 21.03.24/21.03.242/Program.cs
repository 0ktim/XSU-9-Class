namespace _21._03._242
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array.Reverse(nums);

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
