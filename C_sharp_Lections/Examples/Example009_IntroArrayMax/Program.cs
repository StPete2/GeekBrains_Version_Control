int Max (int arg1, int arg2, int arg3)
{
    int Result = arg1;
    if (arg2 > Result) Result = arg2;
    if (arg3 > Result) Result = arg3;
    return Result;
}
int[] array = {11,21,311,41,15,61,17,18,19};

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(max);