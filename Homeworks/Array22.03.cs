namespace Ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Console.Write("Има ли в масива числото: ");
            int num = int.Parse(Console.ReadLine());
            bool yes = false;

            foreach (var number in numbers)
            {
                if (num == number)
                {
                    yes = true;
                    break;
                }

            }

            if (yes)
            {
                Console.WriteLine("Има такова число.");
            }
            else
            {
                Console.WriteLine("Няма такова число.");
            }
        }
    }
}
