while (true)
{


    int[] n1 = { 1, 2, 3, 4, 5 };
    foreach (var item in n1)
    {
        Console.Write(item + " ");
    } 
    Console.Write(" Има ли в масива числото:");
    int[] n = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    int sum = 0;
    for (int i = 0; i < n.Length; i++)
    {
        int t = sum + n1[i];
        if (n[i] <= n1.Length)
        {
            Console.WriteLine("Има!"); break;
        }
        else if (n[i] > n1.Length) { Console.WriteLine("Няма!"); break; }
    }
}