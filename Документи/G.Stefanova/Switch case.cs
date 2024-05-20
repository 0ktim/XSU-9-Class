/*Квартално магазинче
Предприемчив българин отваря квартални магазинчета в няколко града и
продава на различни цени според града:

Град/    |  coffee   |   water    |   beer   |    sweets    |   peanuts
продукт  |  ---------|------------|----------|--------------|------------
Sofia    |   0.50    |    0.80    |    1.20  |      1.45    |     1.60
Plovdiv  |   0.40    |    0.70    |    1.15  |      1.30    |     1.50
Varna    |   0.45    |    0.70    |    1.10  |      1.35    |     1.55
Sliven   |   0.35    |    0.75    |    1.45  |      1.25    |     1.35

Напишете програма, която чете продукт (низ), град (низ) и количество
(десетично число), въведени от потребителя, и пресмята и отпечатва колко
струва съответното количество от избрания продукт в посочения град.*/


using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Въведете продукт:");
string product = Console.ReadLine();
Console.WriteLine("Въведете град:");
string city = Console.ReadLine();
Console.WriteLine("Въведете количество:");
string quantity= Console.ReadLine();



switch (city)
{
    case 1:
        coffee = 0.50;
        Console.WriteLine("");
        break;
}