namespace _21._03._243
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            int[] nums2 = { 4, 5, 6};
            int[] nums3 = new int[nums.Length + nums2.Length];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                nums3[i] = nums[i];
            }
            for (int j = 0; j < nums2.Length - 1; j++)
            {
                nums3[j] = nums[j]; 
            }
            foreach (int g in nums3)
            {
                Console.WriteLine(nums3);
            }


        }
    }
}
