namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете два масива с ' ' :");
            int[] ints = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] ints2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] ints3 = new int[ints.Length + ints2.Length];

            for (int i = 0; i < ints.Length; i++)
            {
                ints3[i] = ints[i];
            }

            for (int j = 0; j < ints2.Length; j++)
            {
                ints3[ints.Length + j] = ints2[j];
            }

            foreach (var int3 in ints3)
            {
                Console.Write(int3 + " ");
            }







        }
    }
}

