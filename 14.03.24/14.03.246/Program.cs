namespace _14._03._246
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = {1,2,3,4,5,6,7,8,9,10};
            double sum = 0;
            foreach (int num in nums) 
            {
                sum += num;
            }
            Console.WriteLine(sum/nums.Length);
        }
    }
}
