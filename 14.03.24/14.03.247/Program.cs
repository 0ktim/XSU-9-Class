namespace _14._03._247
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int position = 0;
            for (int i = 0; i <= nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    position += nums[i];
                }
            }
            Console.WriteLine(position);



        }
    }
}
