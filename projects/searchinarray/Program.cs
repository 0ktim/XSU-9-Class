while (true)
{

    string seprator = new string('-', Console.WindowWidth);
    int[] array = new int[Random.Shared.Next(1, 100)].Select(a => Random.Shared.Next(-100, 100)).ToArray();
    int toSearch = Random.Shared.Next(-100, 100);
    bool found = false;
    Console.WriteLine($"{seprator}{Environment.NewLine}Searching for {toSearch} in array[{string.Join(", ", array)}]{Environment.NewLine}{seprator}");
    foreach (int i in array)
    {
        if (i == toSearch)
        {
            Console.WriteLine($"Item found!{Environment.NewLine}{seprator}");
            found = true;
            break;
        }
    }
    if (!found) Console.WriteLine($"Item not found!{Environment.NewLine}{seprator}");

    Thread.Sleep(100);
    Console.Clear();
}