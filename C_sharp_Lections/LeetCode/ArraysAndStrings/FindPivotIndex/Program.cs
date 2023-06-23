int PivotIndex(int[] nums)
{
    int sumLeft = 0;
    int sumRight = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        int[] numsLeft = new int[i];
        for (int l = 0; l < numsLeft.Length; l++)
        {
            numsLeft[l] = nums[l];
            sumLeft = sumLeft + numsLeft[l];
            Console.Write($"{sumLeft} ");
        }
        Console.WriteLine();
        int[] numsRight = new int[nums.Length];
        for (int r = i+1; r < numsRight.Length; r++)
        {
            numsRight[r]=nums[r];
            sumRight += numsRight[r];
            Console.Write($"{sumRight} ");            
        }
        Console.WriteLine();
        if (sumLeft == sumRight)
        {
            return i;
        }
        sumLeft = 0;
        sumRight = 0;
    }
    return -1;
}
int []array = new int []{1,7,3,6,5,6};
int result = PivotIndex(array);
Console.WriteLine(result);