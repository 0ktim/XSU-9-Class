int n = int.Parse(Console.ReadLine());

int count1 = 0;
int count2 = 0;
int count3 = 0;
int count4 = 0;
int count5 = 0;

int total = 0;
for (int group = 1; group <= n; group++)
{
    int count = int.Parse(Console.ReadLine());
    total += count;

    if (count <= 5)
        count1 += count;
    else if (count <= 12)
        count2 += count;
    else if (count <= 25)
        count3 += count;
    else if (count <= 40)
        count4 += count;
    else
        count5 += count;
}

Console.WriteLine($"{(double)count1 / total * 100:f2}");
Console.WriteLine($"{(double)count2 / total * 100:f2}");
Console.WriteLine($"{(double)count3 / total * 100:f2}");
Console.WriteLine($"{(double)count4 / total * 100:f2}");
Console.WriteLine($"{(double)count5 / total * 100:f2}");