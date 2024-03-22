namespace arrayEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Console.WriteLine();
            foreach (int num in nums)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            Console.Write("Има ли в масива този елемент: ");
            int number = int.Parse(Console.ReadLine());
            bool check = false;
            foreach (int num in nums)
            {
                if (num == number)
                {
                    check = true;
                }
            }
            Console.WriteLine();
            if (check)
            {
                Console.WriteLine("Има");
            }
            else
            {
                Console.WriteLine("Няма");
            }





        }
    }
}
