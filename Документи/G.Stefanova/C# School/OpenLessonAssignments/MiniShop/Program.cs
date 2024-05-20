//Четем данни от конзолата
string town = Console.ReadLine();
string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

//Дефинираме началната цена 
double price = 0;

//Правим проверка
if (town == "Сливен")
{
    switch (product)
    {
        case "Кафе": price = 0.60; break;               //coffeePrice = 0.60;
        case "Вода": price = 0.60; break;               //waterPrice = 0.60;
        case "Вафла": price = 0.50; break;              //vaflaPrice = 0.50;
        case "Чипс": price = 3.45; break;               //chipsPrice = 3.45;
        default:
            break;
    }
}
else if (town == "Нова Загора")
{
    switch (product)
    {
        case "Кафе": price = 0.65; break;               //coffeePrice = 0.65;
        case "Вода": price = 0.70; break;               //waterPrice = 0.70;
        case "Вафла": price = 0.55; break;              //vaflaPrice = 0.55;
        case "Чипс": price = 2.85; break;               //chipsPrice = 2.85;
        default:
            break;
    }
}
else if (town == "Бургас")
{
    switch (product)
    {
        case "Кафе": price = 0.85; break;               //coffeePrice = 0.85;
        case "Вода": price = 0.75; break;               //waterPrice = 0.75;
        case "Вафла": price = 0.65; break;              //vaflaPrice = 0.65;
        case "Чипс": price = 3.15; break;               //chipsPrice = 3.15;
        default:
            break;
    }
}

//Пресмятаме резултата
double finalPrice = quantity * price;

//Отпечатваме на конзолата
Console.WriteLine($"Дължима сума: {finalPrice:f2}");