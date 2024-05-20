using System.ComponentModel.DataAnnotations.Schema;

string[] n = Console.ReadLine().Split(' ');
int sum = 0;

for (int i = 0; i < n.Length; i++)
{
    sum += Convert.ToInt32(n[i]);
}

Console.WriteLine(sum);

