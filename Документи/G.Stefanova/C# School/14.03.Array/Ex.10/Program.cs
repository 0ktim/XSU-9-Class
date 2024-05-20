namespace Ex._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            bool simetriq = false;

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                if (numbers[i] != numbers[numbers.Length - 1 - i])
                {
                    simetriq = false;
                    break;
                }
            }

            if (simetriq)
            {
                Console.WriteLine("Symethric");
            }
            else
            {
                Console.WriteLine("Not symethric");
            }
        }
    }
}
