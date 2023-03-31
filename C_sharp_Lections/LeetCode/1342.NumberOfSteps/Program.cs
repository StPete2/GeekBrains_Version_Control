int numberOfSteps(int num)
{
    int count = 0;
    while (num > 0)
    {
        if (num %2 == 0)
        {
            num = num / 2;
            count++;
        }
        else if (num % 2 != 0)
        {
            num = num - 1;
            count++;
        }
    }   
    return count;
}
Console.WriteLine("Input integer");
int num = Convert.ToInt32(Console.ReadLine());
int count = numberOfSteps(num);
Console.WriteLine(count);
