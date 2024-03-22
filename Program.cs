

int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] array2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] pesho = new int[array.Length + array2.Length];
for (int i = 0; i < array.Length; i++)
{
    pesho[i] = array[i];
}
for (int j = 0; j < array2.Length; j++)
{
    pesho[array.Length + j] = array2[j];
}
foreach(int i in pesho)
{
    Console.WriteLine(i);
}



