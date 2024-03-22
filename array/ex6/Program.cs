using System.Xml.Serialization;

int[] array = {1, 2, 3, 4, 5, 6, 7, 8 };
bool a = true;
for (int i = 0; i < array.Length-1; i++)
{
    if (array[i] > array[i+1])
    { 
        a = false;
        break;
    }
}
if (a) Console.WriteLine("Има");
else Console.WriteLine("Няма");