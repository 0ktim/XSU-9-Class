namespace masiv;
class Program
{
    static void Main(string[] args)
    {
        int[] one = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] two = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] three = new int[one.Length + two.Length];
        for (int i = 0; i < one.Length; i++)
        {
            three[i] = one[i];
        }
        for (int j = 0; j < two.Length; j++)
        {
            three[one.Length + j] = two[j];
        }
        foreach (var num in three)
        {
            Console.Write(num + ",");

        }
    }
}
