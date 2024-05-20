double metres = double.Parse(Console.ReadLine());

double all = 7.61 * metres;
double discount = all * 0.18;
double price = all - discount;
Console.WriteLine($"The final price is: {price} lv.");
Console.WriteLine($"The discount is: {discount} lv.");