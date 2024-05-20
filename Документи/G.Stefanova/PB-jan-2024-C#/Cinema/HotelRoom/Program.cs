Console.Write("Въведете месец: ");
string month = Console.ReadLine();
Console.Write("Брой нощувки: ");
int nights = int.Parse(Console.ReadLine());
double studio = 0.00;
double apartment = 0.00;
double discount = 0.00;

if (month == "May" || month == "October")
{
    studio = 50.00;
    apartment = 65.00;
    if (nights > 14)
    {
        studio = studio - (studio * 0.3);
        apartment = apartment - (apartment * 0.1);
    }
    else if (nights > 7)
    {
        studio = studio - (studio * 0.05);
    }
}

else if (month == "June" || month == "September")
{
    studio = 75.20;
    apartment = 68.70;
    if (nights > 14)
    {
        studio = studio - (studio * 0.2);
        apartment = apartment - (apartment * 0.1);
    }
}

else if (month == "July" || month == "August")
{
    studio = 75.20;
    apartment = 68.70;
    if (nights > 14)
    {
        studio = studio - (studio * 0.1);
        apartment = apartment - (apartment * 0.1);
    }
}
double priceApartment = apartment * nights;
double priceStudio = nights * studio;
Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
Console.WriteLine($"Studio: {priceStudio:f2} lv.");