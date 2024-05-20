int locations = int.Parse(Console.ReadLine());
double needGold = 0;
double average = 0;

for (int i = 0; i < locations; i++)
{
    needGold = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    double sum = 0.0;
    for (int k = 0; k < days; k++)
    {
        double goldPerDay = double.Parse(Console.ReadLine());
        sum += goldPerDay;
        
    }
    average = sum / days;
    if (average >= needGold)
      {
        Console.WriteLine($"Good job! Average gold per day: {average:f2}.\n");
      }
    if (average < needGold)
      {
        double neededGold = needGold - average;
        Console.WriteLine($"You need {neededGold:f2} gold.\n");
      }
}
