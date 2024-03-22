int[] num = {2, 1, 5, 3,};
int sum = 0;
for (int i = 0;num.Length > 0;i++)
{
sum += num[i];
    if (sum == 0)
    {
        num[i] = 0;
    }
}