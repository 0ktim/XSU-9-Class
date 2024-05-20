using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Въведете брой секунди:");
int seconds = int.Parse(Console.ReadLine());
int remainingSeconds = seconds % 60;
int minutes = seconds / 60;
int remainingMinutes = minutes % 60;
int hours = minutes / 60;

if (seconds > 0)
{
    if (remainingSeconds > 0)
    {
        if (remainingMinutes == 0)
        {
            if hou
        }
    }

    else
    {
        Console.WriteLine("Невалидни данни!");
    }
   
}

else if (seconds == 3600)
{
    Console.WriteLine($"Това е {hours} час.");
}

else if (seconds <= 60)
{
    Console.WriteLine($"Това са {seconds} секунди.");
}

else if (seconds > 60 && remainingSeconds < 3600)
{
    Console.WriteLine($"Това са {minutes} минути и {remainingSeconds} секунди.");
}

else if (seconds >= 3600 && remainingMinutes <= 0 && hours > 0)
{
    Console.WriteLine($"Това са {hours} часа и {remainingSeconds} секунди.");
}

else if (seconds > 3600 && remainingMinutes > 0 && hours > 0) 
{
    Console.WriteLine($"Това са {hours} часа, {remainingMinutes} минути и {remainingSeconds} секунди.");
}

