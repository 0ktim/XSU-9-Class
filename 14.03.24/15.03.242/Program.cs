namespace _15._03._242
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int mNumber = 0, hCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int cNumber = nums[i];
                int cCount = 1;
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j] == cNumber)
                    {
                        cCount++;
                    }
                }
                if (cCount > hCount)
                {
                    hCount = cCount;
                    mNumber = cNumber;
                
                }
            }
            Console.WriteLine(mNumber);









        }
    }
}
