namespace _11._04.List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int[] nums = { 1, 2, 3, 4, 5 };
            list.Add(nums[2]);

            //list.AddRange(nums);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            //list.Reverse();

            nums = list.ToArray();

            Console.WriteLine(string.Join(", ", nums));

        }
    }
}
