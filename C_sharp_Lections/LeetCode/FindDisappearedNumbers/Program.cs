using System;
using System.Collections.Generic;
IList<int> FindDisappearedNumbers(int[] nums)
{
    int minPosition;
    int temp;
    for (int i = 0; i < nums.Length - 1; i++)
    {
        minPosition = i;
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[j] < nums[minPosition])
            {
                minPosition = j;
            }
        }
        temp = nums[i];
        nums[i] = nums[minPosition];
        nums[minPosition] = temp;
    }
    List<int> resultList = new List<int>();
    for (int i = 1; i <= nums.Length; i++)
    {
        if (nums[i] != i)
        {
            resultList.Add(i);
        }
    }
    return resultList;
}
int [] inputData = new int []{4,3,2,7,8,2,3,1};
IList<int> result = FindDisappearedNumbers(inputData);
Console.WriteLine(String.Join(" ", result));