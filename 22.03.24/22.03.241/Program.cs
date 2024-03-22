namespace _22._03._241
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int nums2 = 1;
            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums1[i] == nums2)
                {
                    Console.WriteLine("Има");
                }
                else
                {
                    Console.WriteLine("Няма");
                    break;
                }

            }




        }
    }
}
