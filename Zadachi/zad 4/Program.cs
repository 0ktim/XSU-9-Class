
int[] num = new int[1001];
for (int i = 0; i < num.Length - 1; i++)
{
    num[i] = i;
}  
foreach (int n in num)
{
    Console.WriteLine(n); 
}