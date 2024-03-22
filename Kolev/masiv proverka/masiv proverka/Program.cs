int[] n1 = { 1, 2, 3, 4, 5 };
int[] n = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int sum = 0;
for (int i = 0; i < n.Length; i++)
{
    sum += n[i];
    if (sum == n1[i])
    {
        Console.WriteLine("yes"); break;
    }
    else { Console.WriteLine("no"); break; }
}
