namespace _15._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray() ;



            Console.WriteLine($"Най-малкото число е: {nums.Min()}");
            Console.WriteLine($"Най-голямото число е: {nums.Max()}");
            Console.WriteLine($"Сбора на числата е: {nums.Sum()}");
            Console.WriteLine($"Средно Аритметично на числата е: {nums.Average()}");






        }
    }
}
