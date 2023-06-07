int[] copyWithRemovedDuplicates(int[] nums)
{
    if (nums == null || nums.Length == 0)
    {
        return nums;
    }

    int uniqueNumbers = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (i == 0 || nums[i] != nums[i - 1])
        {
            uniqueNumbers++;
        }
    }

    int[] result = new int[uniqueNumbers];

    int positionInResult = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (i == 0 || nums[i] != nums[i - 1])
        {
            result[positionInResult] = nums[i];
            positionInResult++;
        }
    }
    return result;
}
int [] nums = new int [] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
int []result = copyWithRemovedDuplicates(nums);
Console.WriteLine(String.Join(" ", result));