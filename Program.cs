while (true)
{
    int[] da1 = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
    int[] da2 = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
    Console.Clear();
    int[] da3 = new int[da1.Length + da2.Length];
    for (int i = 0; i < da1.Length; i++)
    {
        da3[i] = da1[i];
    }
    for (int j = 0; j < da2.Length; j++)
    {
        da3[da1.Length + j] = da2[j];
    }
    foreach (var asd in da3)
    {
        Console.Write(asd);
    }
}