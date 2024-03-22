using System.Threading.Channels;

int[] num = new int[5];
for (int i = 0; i < num.Length; i++)
{
    num[i] = int.Parse (Console.ReadLine()); 
}
foreach (int n in num)
{
    Console.WriteLine(n);
}