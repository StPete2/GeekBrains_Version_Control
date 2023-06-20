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
    Console.WriteLine(String.Join(" ", nums));
    List<int> resultList = new List<int>();
    int k = 1;
    // if (nums[0] != k)
    // {
    //     for (int n = 1; n < nums[0]; n++)
    //     {
    //         resultList.Add(k);                      
    //         k++;
    //     }
    // }    
    // k++;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != k)
        {
            if (nums[i]<k)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[j]==k)
                    {
                        k++;
                        break;
                    }
                }
                if (i == nums.Length-1)
                {
                    for (int m = k; m < nums.Length+1; m++)
                    {
                        resultList.Add(k);
                        k++;
                    }
                }              
            }
            else if (nums[i]>k)
            {
                for (int l = k; l < nums[i]; l++)
                {
                    resultList.Add(k);                    
                    Console.WriteLine($"l {l}, nums[i] {nums[i]}");                                        
                    k++;
                    if (nums[i]==k)
                    {
                        k++;    
                    }                        
                }                                 
            }
        }
        else
        {
            if (i == nums.Length-1 && nums[i]==k && k!=nums.Length)
            {
                resultList.Add(k+1);
            }
            k++;
        }
    }
    return resultList;
}
int [] inputData = new int []{4,3,2,7,8,2,3,1};
int [] inputData2 = new int[]{1,1,1,1,1,1,1,1};
int [] inputData3 = new int[]{1,1,1,1,2,2,2,2};
int [] inputData4 = new int []{5,4,6,7,9,3,10,9,5,6};
int [] inputData10 = new int []{27,40,6,21,14,36,10,19,44,10,41,26,39,20,25,19,14,7,29,27,40,38,11,44,4,6,48,39,9,13,7,45,41,23,31,8,24,1,3,5,28,11,49,29,18,4,38,32,24,15};
int []inputData7 = new int []{1,2,2,2,4,5};
IList<int> result = FindDisappearedNumbers(inputData4);
Console.WriteLine(String.Join(" ", result));