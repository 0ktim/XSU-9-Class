string[] num =Console.ReadLine().Split(" ");

int sum = 0;

for (int i = 0; i < num.Length; i++)
{
    sum += Convert.ToInt32(num[i]);
}

Console.WriteLine(sum);