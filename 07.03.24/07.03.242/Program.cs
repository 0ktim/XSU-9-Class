namespace _07._03._242
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            

            foreach (int i in nums)
            {
                if (i <= nums.Length - 1)
                {
                    Console.Write($"{i}, ");
                }
                else
                {
                    Console.Write($"{i}.");
                }
                
            }
        }
    }
}
