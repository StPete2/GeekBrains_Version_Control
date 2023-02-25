int a1 = 15;
int b1 = 32;
int c1 = 39;
int a2 = 12;
int b2 = 2323;
int c2 = 33;
int a3 = 312;
int b3 = 32;
int c3 = 33;

int Max (int arg1, int arg2, int arg3)
{
    int Result = arg1;
    if (arg2 > Result) Result = arg2;
    if (arg3 > Result) Result = arg3;
    return Result;
}
// int max1 = Max (a1, b1, c1);
// int max2 = Max (a2, b2, c2);
// int max3 = Max (a3, b3, c3);

// int max = Max (max1, max2, max3);

int max = Max (Max (a1, b1, c1), Max (a2, b2, c2), Max (a3, b3, c3));

Console.WriteLine (max);