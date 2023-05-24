int RemoveElement(int[] nums, int val)
{
    int counterVal = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == val)
        {
            counterVal++;
        }
    }
    int k = nums.Length - counterVal;
    int[] expectedNums = new int[nums.Length-counterVal];
    int expectedNumsCounter = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i]!=val) 
        {
            expectedNums[expectedNumsCounter] = nums[i];
            expectedNumsCounter++;
        }
    }
    for (int i = 0; i < k; i++)
    {
        nums[i] = expectedNums[i];
    }
    return k;
}
int [] nums = new int [] {3,2,2,3};
int val = 3;
int result = RemoveElement(nums, val);
Console.WriteLine(result);
Console.WriteLine(String.Join(", ", nums));