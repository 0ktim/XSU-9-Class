int firstPlayer = int.Parse(Console.ReadLine());
int secondPlayer = int.Parse(Console.ReadLine());
int thirdPlayer = int.Parse(Console.ReadLine());

int sumSeconds = firstPlayer + secondPlayer + thirdPlayer;

int minutes = sumSeconds / 60;
int seconds = sumSeconds % 60;
if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");

}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}