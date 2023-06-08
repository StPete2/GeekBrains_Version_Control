void MoveZeroes(int[] nums)
{
    int nonZeroesCounter = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i]!=0)
        {
            nonZeroesCounter++;
        }
    }
    if (nonZeroesCounter!=0 && nonZeroesCounter !=nums.Length)
    {
        // int[] additionalArray = new int[nonZeroesCounter];
        int additionalNumsIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[additionalNumsIndex] = nums[i];
                additionalNumsIndex++;
            }
        }
        additionalNumsIndex = 0;
        for (int i = nums.Length - 1; i >= nonZeroesCounter; i--)
        {
                nums[i] = 0;
        }
        // for (int i = 0; i < nonZeroesCounter; i++)
        // {
        //     nums[i] = additionalArray[additionalArrayIndex];
        //     additionalArrayIndex++;
        // }    
        return;
    }
    else
    {
        return;
    }
}
int [] nums = new int [] {0,1,0,3,12};
MoveZeroes(nums);
Console.WriteLine(String.Join(" ", nums));