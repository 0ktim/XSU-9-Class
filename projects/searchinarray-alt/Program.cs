string seprator = new string('-', Console.WindowWidth);
int[] array = new int[Random.Shared.Next(1, 100)].Select(a => Random.Shared.Next(-100, 100)).ToArray();

Console.Write($"{seprator}{Environment.NewLine}in array[{string.Join(", ", array)}]{Environment.NewLine}Search for: ");
int toSearch = int.Parse(Console.ReadLine());
bool found = false;
Console.WriteLine($"{seprator}");

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
