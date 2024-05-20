//1.Четем вход от конзолата
//=> възраст
int age = int.Parse(Console.ReadLine());
//=> цена на пералнята
double washingmachine = double.Parse(Console.ReadLine());
//=> цена за една играчка
int toyPrice = int.Parse(Console.ReadLine());

//2.Създаваме променлива, в която пазим парите, които Лили спестява
int money = 0;


//3.Създаваме цикъл, който да премине през всеки рожден ден на Лили
for (int birthday = 1; birthday <= age; birthday++)
{
	//=> проверяваме дали РД е четен
	if (birthday % 2 == 0)
	{
		//===> ако е: 5 - 1
		money += (birthday * 5) - 1;
	}
	//===> ако не е: към спестяванията += цена за играчка
	else
	{
	money += toyPrice;
	}
	////=> пари за четен рожден ден = годините, които навършва * 5 - 1

}

if (money >= washingmachine)
{
    Console.WriteLine($"Yes! {money - washingmachine:f2}");
}

else
{
    Console.WriteLine($"No! {washingmachine - money:f2}");
}

//4.Проверяваме дали парите са достатъчни да си купи пералнята
//=> ако са: "Yes, {sum}
//=> ако не са: "No, {needMoney}"