﻿double age = double.Parse(Console.ReadLine());
string sex = Console.ReadLine();
if (age < 16)
{
    if (sex == "m")
    {
        Console.WriteLine("Master");
    }
    else if (sex == "f")
    {
        Console.WriteLine("Miss");
    }
}
else if (age >= 16)
{
	if (sex == "m")
	{
        Console.WriteLine("Mr.");
    }
    else if (sex == "f")
    {
        Console.WriteLine("Ms.");
    }
}