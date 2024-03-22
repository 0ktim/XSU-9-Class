int[] nums = { 1, 2, 3, 4, 2, 5, 1, 6, 2 };
int mNumber = 0;
int hCount = 0;

for (int i = 0; i < nums.Length; i++)
{
    int cNumber = nums[1];
    int cCount = 1;

    for (int j = i + 1; j < nums.Length; j++)
    {

        if (cNumber == nums[j])
        {
            cCount++;
        }

    }

    if (cCount > hCount)
    {
        mNumber = cNumber;
        hCount = cCount;
    }

}
Console.WriteLine(mNumber);  