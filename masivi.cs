// See https://aka.ms/new-console-template for more information
int[] numbers1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] numbers2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] nums3 = new int[numbers1.Length + numbers2.Length];
for (int i = 0; i < numbers1.Length; i++)
{
    nums3[i] = numbers1[i];
}
for (int j = 0; j < numbers2.Length; j++)
{
    nums3[numbers1.Length + j] = numbers2[j];
}
foreach (var item in nums3)
{
    Console.WriteLine(item);
}
