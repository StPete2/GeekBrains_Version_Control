using System.Diagnostics;
var sw = new Stopwatch();
sw.Start();
int [] SortedSquares(int []nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i]*=nums[i];
    }
    for (int j = 0; j < nums.Length-1; j++)
    {
        int minPosition = j;
        for (int k = j+1; k < nums.Length; k++)
        {
            if (nums[k] < nums[minPosition])
            {
                minPosition = k;
            }
        }
        int temp = nums[j];
        nums[j] = nums[minPosition];
        nums[minPosition] = temp;
    }
    Console.WriteLine(String.Join(", ", nums));
    return nums;    
}
int [] nums = new int [] {-4,-1,0,30,10};
int [] result = SortedSquares(nums);
// Console.WriteLine(String.Join(", ", result));
sw.Stop();
Console.WriteLine(sw.Elapsed);//00:00:00.0091756