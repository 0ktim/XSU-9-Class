using System.Runtime.CompilerServices;

namespace _14._03._249
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 3, 2, 1 };
            bool isSymmetric = true;
            for (int i = 0; i < nums.Length / 2; i++)
            {
                if (nums[i] != nums[nums.Length - 1 -i])
                {
                    isSymmetric = false;
                    break;
                }
            }
            if (isSymmetric)
            {
                Console.WriteLine("Масива е симетричен!");
            }
            else
            {
                Console.WriteLine("Масива не е симетричен!");
            }
        }
    }
}
