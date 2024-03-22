string seprator = new string('-', Console.WindowWidth);

int[] array1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).Select(int.Parse).ToArray();
int[] array2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).Select(int.Parse).ToArray();
//int[] array3 = array1.Concat(array2).ToArray();

int[] array3 = new int[array1.Length + array2.Length];



for (int i = 0; i < array1.Length; i++)
{
    array3[i] = array1[i];
}

for (int i = 0; i < array2.Length; i++)
{
    array3[i + array1.Length] = array2[i];
}

Console.WriteLine($"{seprator}{Environment.NewLine}" +
                  $"[{string.Join(", ", array1)}]{Environment.NewLine}{Environment.NewLine}" +
                  $"[{string.Join(", ", array2)}]{Environment.NewLine}{seprator}{Environment.NewLine}" +
                  $"[{string.Join(", ", array3)}]{Environment.NewLine}{seprator}");
