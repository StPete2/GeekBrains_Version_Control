int removeDuplicates(int[] nums)
{
    int length = nums.Length;

    for (int i = length - 2; i >= 0; i--)
    {
        if (nums[i] == nums[i + 1])
        {
            for (int j = i + 1; j < length; j++)
            {
                nums[j - 1] = nums[j];
                Console.WriteLine($"nums[j-1]: {nums[j-1]} i: {i}");
            }            
            Console.WriteLine(String.Join(" ", nums));
            Console.WriteLine("Новый цикл");
            length--;
        }
    }    
    return length;
}
int [] new_nums = new int []{0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
int k = removeDuplicates(new_nums);
Console.WriteLine(k);