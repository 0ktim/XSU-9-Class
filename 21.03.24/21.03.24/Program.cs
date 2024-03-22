using System.Diagnostics.CodeAnalysis;

namespace _21._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int average = 0;
                int sum = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                sum += nums[i];
                
            }
            average = sum / nums.Length;
            Console.WriteLine(average);
        }
    }
}
