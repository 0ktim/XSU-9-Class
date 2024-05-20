double record = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double distanceInSeconds = double.Parse(Console.ReadLine());

double distanceTime = distanceInMeters * distanceInSeconds;
double resistanceTime = Math.Floor((distanceInMeters / 15)) * 12.5;
double time = distanceTime + resistanceTime;

if (time < record)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {time:f2} seconds.");
}
else
{
    double needTime = time - record;
    Console.WriteLine($"No, he failed! He was {needTime:f2} seconds slower.");
}