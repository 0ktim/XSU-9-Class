namespace _2.Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int hCount = 0;
            int maxNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int currentCounter = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    

                    if (numbers[i] == currentNumber)
                    {
                        currentCounter++;
                    }
                }
                if (currentCounter >= hCount)
                {
                    maxNumber = currentNumber;
                    hCount = currentCounter;
                }

            }
            Console.WriteLine(maxNumber);
        }
    }
}
