namespace _22._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Въведете първата част от масива:");
                int[] nums1 = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                Console.WriteLine("Въведете втората част от масива:");
                int[] nums2 = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                Console.Clear();
                int[] nums3 = new int[nums1.Length + nums2.Length];
                for (int i = 0; i < nums1.Length; i++)
                {
                    nums3[i] = nums1[i];
                }
                for (int j = 0; j < nums2.Length; j++)
                {
                    nums3[nums1.Length + j] = nums2[j];
                }
                foreach (int num3 in nums3)
                {
                    if (num3 == nums3.Length)
                    {
                        Console.Write($"{num3}.");
                    }
                    else
                    {
                        Console.Write($"{num3}, ");
                    }
                }
                Thread.Sleep(1000);
                Console.Clear();
            }







        }
    }
}
