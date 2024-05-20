namespace Ex._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int> { -921, 21, 3, 473, 5, -2374 };

            int max = FindMax(numbers);
            int min = FindMin(numbers);
            Console.WriteLine(max);
            Console.WriteLine(min);










            static int FindMax(List<int> numbers)
            {
                int maxNum = int.MinValue;
                foreach (var item in numbers)
                {
                    if (maxNum < item)
                    {
                        maxNum = item;
                    }
                }
                return maxNum;
            }

            static int FindMin(List<int> numbers)
            {
                int minNum = int.MaxValue;
                foreach (var item in numbers)
                {
                    if (minNum > item)
                    {
                        minNum = item;
                    }
                }
                return minNum;
            }
        }
    }
}
