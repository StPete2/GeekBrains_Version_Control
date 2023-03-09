int SumNegative(int [] array)
{
    int sum = 0;
    foreach (int el in array)
    {
        sum += el < 0 ? el:0;
    }
}