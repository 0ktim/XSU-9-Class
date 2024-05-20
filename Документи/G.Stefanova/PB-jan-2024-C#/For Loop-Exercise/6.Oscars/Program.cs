//1.Четем данни от конзолата 
//=> име на актьора 
//=> точки от академията
//=> брой оценители
string nameActor = Console.ReadLine();
double pointsFromAcademy = double.Parse(Console.ReadLine());
int ratings = int.Parse(Console.ReadLine());

//2.Дефинираме стойности на променливи
double sumPoints = pointsFromAcademy;
bool flag = false;

//3.Проверяваме колко е броят на оценителите и пресмятаме точките, дадени на актьорите
for (int ratingPeople = 0; ratingPeople < ratings; ratingPeople++)
{
    string nameRating = Console.ReadLine();
    double pointsRating = double.Parse(Console.ReadLine());
    double points = (nameRating.Length * pointsRating) / 2;
    sumPoints = sumPoints + points;

    if (sumPoints >= 1250.5)
    {
        flag = true;
        break;
    }
}

//4.Правим проверка колко е резултатът и го отпечатваме на конзолата
//==> ако е повече от 1250.5: "Congratulations, {nameActor} got a nominee for leading role with {sumPoints:f1}!"
//==> ако е по-малък от 1250.5: "Sorry, {nameActor} you need {needPoints:f1} more!"
if (flag)
{
    Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {sumPoints:f1}!");
}
else
{
    double needPoints = 1250.5 - sumPoints;
    Console.WriteLine($"Sorry, {nameActor} you need {needPoints:f1} more!");
}