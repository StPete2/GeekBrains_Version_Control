int FindNumbers(int[] nums)
{
    int countDigits = 1;
    int countEven = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        while (nums[i] / 10 != 0)
        {
            countDigits++;
            nums[i] /= 10;            
        }
        Console.WriteLine($"количество {countDigits} число {nums[i]}");
        if (countDigits % 2 == 0)
        {
            countEven++;
        }
        countDigits = 1;
    }
    return countEven;
}
int[] nums = new int [] {1,12,333,444,4441,343};
int [] nums2 = new int [] {580,317,640,957,718,764};
int result = FindNumbers(nums);
Console.WriteLine(result);