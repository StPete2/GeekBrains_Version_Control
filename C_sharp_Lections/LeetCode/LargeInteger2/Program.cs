int[] PlusOne(int[] digits)
{
    int n = digits.Length;
    for (int i = n - 1; i >= 0; i--)
    {
        if (digits[i] < 9)
        {
            digits[i]++;
            return digits;
        }
        digits[i] = 0;
    }
    int[] newNumber = new int[n + 1];
    newNumber[0] = 1;

    return newNumber;
}
int []array = new int []{9,2,3,4,5};
int[] array10 = new int []{9,8,7,6,5,4,3,2,1,0};
int []array2 = new int []{9};
int [] result = PlusOne(array10);
Console.WriteLine(String.Join(" ", result));