string serialName = Console.ReadLine();
int time = int.Parse(Console.ReadLine());
int breakTime = int.Parse(Console.ReadLine());

double lunchTime = breakTime * 0.125;
double timeForBreak = breakTime * 0.25;
double freeTime = Math.Ceiling(time + lunchTime + timeForBreak);

if (freeTime <= breakTime)
{
    Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(breakTime - freeTime)} minutes free time.");
}
else
{
    double leftTime = Math.Ceiling(freeTime - breakTime);
    Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(leftTime)} more minutes.");
}