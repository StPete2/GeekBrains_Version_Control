int ThirdMax(int[] nums) 
{
    if (nums.Length == 1)
    {
        return nums[0];
    }
    else if (nums.Length == 2)
    {
        if (nums[0]>nums[1])
        {
            return nums[0];
        }
        else
        {
            return nums[1];
        }
    }
    else
    {        
        int min = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i]<min)
            {
                min = nums[i];
            }
        }
        int firstMax = min;
        int secondMax = min;
        int thirdMax = min;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i]>firstMax)
            {
                firstMax = nums[i];
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i]>secondMax && nums[i]!=firstMax)
            {
                secondMax = nums[i];
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i]>thirdMax && nums[i]!=secondMax && nums[i]!=firstMax)
            {
                thirdMax = nums[i];
            }
        }
        if (secondMax!=thirdMax && secondMax!=firstMax)
        {
            return thirdMax;
        }        
        else
        {
            return firstMax;
        }
    }     
}
int [] nums = new int [] {1,2,2,2,2};
int result = ThirdMax(nums);
Console.WriteLine(result);
