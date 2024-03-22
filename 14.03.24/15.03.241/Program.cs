namespace _15._03._241
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int maxCount = 0;
            int repeatingNumber = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currentCount = 0;

                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        currentCount++;
                    }
                }

                if (currentCount > maxCount)
                {
                    repeatingNumber = nums[i];
                    maxCount = currentCount;
                }
            }

            Console.WriteLine(repeatingNumber);




        }
    }
}
