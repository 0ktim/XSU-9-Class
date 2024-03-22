string numberHex = Console.ReadLine();  
int number10 = Convert.ToInt32(numberHex, 16);
Console.WriteLine( number10);

string dec = Console.ReadLine();    
int num2 = Convert.ToInt32(dec, 2);
Console.WriteLine(num2);

int decim = int.Parse(Console.ReadLine());
string hexValue = decim.ToString("X");
Console.WriteLine(hexValue);
switch (num2)
{
    case 1:
        Console.WriteLine();
        break;
}

