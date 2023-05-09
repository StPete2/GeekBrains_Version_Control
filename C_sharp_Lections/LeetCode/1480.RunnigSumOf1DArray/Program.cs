int []nums = new int [] {1,2,3,4};
int []RunningSum(int []nums)
{
    int [] runningSum = new int [nums.Length];
    int sum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        sum += nums[i];
        runningSum[i] = sum;
    }
    return runningSum;
}
