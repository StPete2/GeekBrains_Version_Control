string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i}";        
    }    
    return result;    
}
Console.WriteLine(NumbersFor(1,9));

string NumbersRec(int a, int b)
{
    if (a<=b)
    {
        return NumbersRec(a+1,b) + $"{a}";
    } 
    else
    {
        return String.Empty;
    }
}
Console.WriteLine(NumbersRec(1,9));

int SumRec(int n)
{
    if (n==0)
    {
        return 0;
    }
    else
    {
        return n + SumRec(n-1);
    }
}
Console.WriteLine(SumRec(10));