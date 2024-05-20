string town = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());

double commission = 0;
if (town == "Sofia")
{
    if (sales >= 0 && sales <= 500)
    {
        commission = 0.05;
        Console.WriteLine($"{(sales * commission):f2}");
    }
    else if (sales > 500 && sales <= 1000)
    {
        commission = 0.07;
        Console.WriteLine($"{(sales * commission):f2}");
    }
    else if (sales > 1000 && sales <= 10000)
    {
        commission = 0.08;
        Console.WriteLine($"{(sales * commission):f2}");
    }
    else if (sales > 10000)
    {
        commission = 0.12;
        Console.WriteLine($"{(sales * commission):f2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}
else if (town == "Varna")
{
    if (sales >= 0 && sales <= 500)
    {
        commission = 0.045;
        Console.WriteLine($"{(sales * commission):f2}");
    }
    else if (sales > 500 && sales <= 1000)
    {
        commission = 0.075;
        Console.WriteLine($"{(sales * commission):f2}");
    }
    else if (sales > 1000 && sales <= 10000)
    {
        commission = 0.1;
        Console.WriteLine($"{(sales * commission):f2}");
    }
    else if (sales > 10000)
    {
        commission = 0.13;
        Console.WriteLine($"{(sales * commission):f2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}
else if (town == "Plovdiv")
{
    if (sales >= 0 && sales <= 500)
    {
        commission = 0.055;
        Console.WriteLine($"{(sales * commission):f2}");
    }
    else if (sales > 500 && sales <= 1000)
    {
        commission = 0.08;
        Console.WriteLine($"{(sales * commission):f2}");
    }
    else if (sales > 1000 && sales <= 10000)
    {
        commission = 0.12;
        Console.WriteLine($"{(sales * commission):f2}");
    }
    else if (sales > 10000)
    {
        commission = 0.145;
        Console.WriteLine($"{(sales * commission):f2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}
else
{
    Console.WriteLine("error");
}