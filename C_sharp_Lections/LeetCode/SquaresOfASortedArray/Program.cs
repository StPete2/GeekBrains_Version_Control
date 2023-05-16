using System.Diagnostics;
var sw = new Stopwatch();
sw.Start();
int [] SortedSquares(int []nums)
{
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i]<0)
        {
            count ++;
            nums[i] = nums[i]*(-1);
        }
        else
        {
            break;
        }
    }
    int temp = 0;
    for (int j = 0; j < count; j++) //j max 2, 3 times repeat;
    {
        int count2 = 0;
        for (int k = nums.Length-1; k >= 0; --k)// k max 7
        {
            if (nums[0] > nums[k])
            {
                count2 = k;//count2 max 7;
                break;
            }
            // else
            // {
            //     break;
            // }   
        }        
        temp = nums[0];
        for (int i = 0; i < count2; i++)
        {
            nums[i] = nums[i + 1];
        }
        nums[count2] = temp;
        Console.WriteLine(String.Join(", ", nums));
    }
    // for (int i = 0; i < nums.Length; i++)
    // {
    //     nums[i] *= nums[i];
    // }
    return nums;
}
int [] nums = new int [] {-4,-1,0,3,10};
int [] result = SortedSquares(nums);
// Console.WriteLine(String.Join(", ", result));
sw.Stop();
Console.WriteLine(sw.Elapsed);//00:00:00.0096941