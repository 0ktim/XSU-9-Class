string input = Console.ReadLine();
int sum = 0;

for (int i = 0; i < input.Length; i++)
{
    char letter = input[i];

	if (letter == 'a')
		sum += 1;
	else if (letter == 'e')
		sum += 2;
    else if (letter == 'i')
        sum += 3;
    else if (letter == 'o')
        sum += 4;
    else if (letter == 'u')
        sum += 5;
}

Console.WriteLine(sum);