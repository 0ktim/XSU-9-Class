while (true)
{


    //int[] n1 = {1, 2, 3, 4, 5 };
    
    int[] n = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    Console.Write(" Има ли в масива числото:");
    int sum =  int.Parse(Console.ReadLine());
    bool m = false;
    foreach (var num in n)
    {
        if (sum == num)
        {
            m = true;break;
            
        }
    }
    if (m)
    {
        Console.WriteLine("Има!");
    }
    else {
        Console.WriteLine("Няма!");
         }
}