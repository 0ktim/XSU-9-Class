int inputHours = int.Parse(Console.ReadLine());
int inputMinutes = int.Parse(Console.ReadLine());

int minutesPlus15 = inputMinutes + 15;

int hours = inputHours + minutesPlus15 / 60;
int minutes = minutesPlus15 % 60;

if (hours == 24)
{
    hours = 0;
}

if (minutes < 10)
{
    Console.WriteLine($"{hours}:0{minutes}");
}
else
{
    Console.WriteLine($"{hours}:{minutes}");
}