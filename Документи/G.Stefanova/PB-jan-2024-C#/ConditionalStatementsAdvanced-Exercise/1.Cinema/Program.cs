//1.Четем данни от конзолата
string ticketsType = Console.ReadLine();
int row = int.Parse(Console.ReadLine());
int col = int.Parse(Console.ReadLine());
//2.Намираме броя на местата
double income = row * col;
//3.Проверяваме какъв е типа на прожекцията
switch (ticketsType)
{
	case "Premiere":
		income *= 12.00;
		break;
	case "Normal":
		income *= 7.50;
		break;
	case "Discount":
		income *= 5.00;
		break;
}
Console.WriteLine($"{income:f2} leva");
//4.Отпечатваме резултата на конзолата