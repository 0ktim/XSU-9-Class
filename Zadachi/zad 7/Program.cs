internal class Program
{
    private static void Main(string[] args)
    {
        int[] num = { 2, 3, 4, 5, 6, 1 };
        int sum = 0;

        foreach (int i in num)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }
}