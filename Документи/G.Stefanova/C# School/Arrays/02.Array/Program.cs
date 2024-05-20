int[] numbers = { 2, 3, 4, 5, 6, 1 };
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

//foreach (var item in numbers)
//{
//    sum += item;
//}

//Console.WriteLine(numbers.Sum());

Console.WriteLine(numbers.Average());
Console.WriteLine(numbers.Max());
Console.WriteLine(numbers.Min());
Console.WriteLine(sum);