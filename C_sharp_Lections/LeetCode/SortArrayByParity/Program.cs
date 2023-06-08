int[] SortArrayByParity(int[] nums) 
{
    int [] resultArray = new int [nums.Length];
    int fromLeftToRightIndex = 0;
    int fromRightToLeftIndex = nums.Length-1;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i]%2 == 0)
        {
            resultArray[fromLeftToRightIndex] = nums[i];
            fromLeftToRightIndex++;
        }
        else
        {
            resultArray[fromRightToLeftIndex] = nums[i];
            fromRightToLeftIndex--;
        }
    }
    return resultArray;
}
int [] nums = new int [] {3,1,2,4};
int [] resultArray = SortArrayByParity(nums);
Console.WriteLine(String.Join(" ", resultArray));