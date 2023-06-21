IList<int> FindDisappearedNumbers(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        int index = Math.Abs(nums[i]) - 1;
        if (nums[index] > 0) nums[index] = -nums[index];
    }
    List<int> result = new List<int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > 0) result.Add(i + 1);
    }
    return result;
}
int [] inputData = new int []{4,3,2,7,8,2,3,1};
int [] inputData2 = new int[]{1,1,1,1,1,1,1,1};
int [] inputData3 = new int[]{1,1,1,1,2,2,2,2};
int [] inputData4 = new int []{5,4,6,7,9,3,10,9,5,6};
int [] inputData10 = new int []{27,40,6,21,14,36,10,19,44,10,41,26,39,20,25,19,14,7,29,27,40,38,11,44,4,6,48,39,9,13,7,45,41,23,31,8,24,1,3,5,28,11,49,29,18,4,38,32,24,15};
int []inputData7 = new int []{1,2,2,2,4,5};
IList<int> result = FindDisappearedNumbers(inputData4);
Console.WriteLine(String.Join(" ", result));