int n = int.Parse(Console.ReadLine());
int left = 0;
int right = 0;

for (int i = 0; i < n; i++)
{
    int leftNum = int.Parse(Console.ReadLine());
    left += leftNum;
}

for (int i = 0; i < n; i++)
{
    int rightNum = int.Parse(Console.ReadLine());
    right += rightNum;
}

if (left == right)
{
    Console.WriteLine($"Yes, sum = {right}");
}

else if (left != right)
{
    int diff = Math.Abs(right - left);
    Console.WriteLine($"No, diff = {diff}");
}