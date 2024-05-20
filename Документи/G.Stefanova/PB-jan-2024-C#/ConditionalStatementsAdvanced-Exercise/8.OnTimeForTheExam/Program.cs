int hourForExam = int.Parse(Console.ReadLine());
int minuteForExam = int.Parse(Console.ReadLine());
int hourArrive = int.Parse(Console.ReadLine());
int minuteArrive = int.Parse(Console.ReadLine());

int totalExamMinutes = hourForExam * 60 + minuteForExam;
int totalArriveMinutes = hourArrive * 60 + minuteArrive;
int difference = totalExamMinutes - totalArriveMinutes;
int diffHours = 0;

if (difference < -30)
{
    Console.WriteLine("Early");
}
else if (difference <= 0)
{
    Console.WriteLine("On time");

}
else
{
    Console.WriteLine("Late");
}

if (difference != 0)
{
    int hours = Math.Abs(difference / 60);
    int minutes = Math.Abs(difference % 60);

    if (hours > 0)
    {
        if (minutes < 10)
        {
            Console.Write(hours + ":0" + minutes + " hours");
        }
        else
        {
            Console.Write(hours + ":" + minutes + " hours");
        }
    }
    else
    {
        Console.Write(minutes + " minutes");
    }
    if (difference < 0)
    {
        Console.WriteLine(" before the start");
    }
    else
    {
        Console.WriteLine(" after the start");
    }
}