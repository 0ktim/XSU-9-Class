namespace _2.Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int maxNum = 0;
            int repetNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int counter = 0;

                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                }
                if (counter > maxNum)
                {
                    repetNumber = numbers[i];
                    maxNum = counter;
                }
            }
            Console.WriteLine(repetNumber);

        }
    }
}
