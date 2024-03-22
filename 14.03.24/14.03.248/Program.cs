namespace _14._03._248
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 17, 215, 34, 43, 59 };
            Array.Sort(nums);
            Array.Reverse(nums);
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
