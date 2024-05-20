//1. Четем данните от конзолата 
int degrees = int.Parse(Console.ReadLine());
string dayTime = Console.ReadLine();

//2. Създаваме 2 променливи, които да пазят облеклото и обувките
string outfit;
string shoes;

//3. Правим външна проверка за времето от денонощието 
if (dayTime == "Morning")
{
    if (degrees <= 18)
    {
        outfit = "Sweatshirt";
        shoes = "Sneakers";
    }
    else if (degrees <= 24)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else // degrees >= 25
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
}
else if (dayTime == "Afternoon")
{
    if (degrees <= 18)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (degrees <= 24)
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    else // degrees >= 25
    {
        outfit = "Swim Suit";
        shoes = "Barefoot";
    }
}
else //Evening
{
    outfit = "Shirt";
    shoes = "Moccasins";
}
//=> вътрешна проверка за температурата

//4. Отпечатваме изхода на конзолата
Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");