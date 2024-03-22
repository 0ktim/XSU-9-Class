int[] num = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int[] number = new int[num.Length + nums.Length];
for (int i = 0; i < num.Length; i++)
{
    number[i] = num[i];
}
for (int j = 0; j < nums.Length; j++)
{
    number[num.Length + j] = nums[j];
}
foreach (int n in number)
{
    Console.WriteLine(n);
}