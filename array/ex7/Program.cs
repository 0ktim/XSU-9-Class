int[] nums = {1, 2, 3, };

int Lengths = nums.Length;
int sum = 0;
foreach (var number in nums)
{
    sum += number;
}
Console.WriteLine(sum / Lengths);

