namespace _07._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[1001]; 
            for (int i = 0; i <= nums.Length-1; i++)
            {
                nums[i] = i;
            }
            foreach (var item in nums)
            {
                if (item < nums.Length-1)
                {
                    Console.Write($"{item} ,");
                }
                else
                {
                Console.Write($"{item}.");
                }
            }
           
            
        }
    }
}
