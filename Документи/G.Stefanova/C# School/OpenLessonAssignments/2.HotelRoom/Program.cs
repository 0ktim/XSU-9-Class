//Четем данни от конзолата
string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());

//Дефинираме стойностите за апартамент и струдио
double studioPrice = 0;
double apartmentPrice = 0;
//Правим проверка
if (month == "May" || month == "October")
{
    studioPrice = 50.00;
    apartmentPrice = 65.00;
    if (nights >= 7)
    {
        studioPrice *= 0.75; //25% отстъпка
    }
}
else if (month == "June" || month == "September")
{
    studioPrice = 75.20;
    apartmentPrice = 68.70;
    if (nights >= 10)
    {
        studioPrice *= 0.85; //15% отстъпка
    }
}
else if (month == "July" || month == "August")
{
    studioPrice = 76.00;
    apartmentPrice = 77.00;
    if (nights >= 10)
    {
        apartmentPrice *= 0.95; //5% отстъпка
    }
}

//Пресмятаме резултата
double finalPriceForApartment = nights * apartmentPrice;
double finalPriceForStudio = nights * studioPrice;

//Отпечатваме резултата на конзолата
Console.WriteLine($"Апартамент: {finalPriceForApartment:f2} лв.");
Console.WriteLine($"Студио: {finalPriceForStudio:f2} лв.");