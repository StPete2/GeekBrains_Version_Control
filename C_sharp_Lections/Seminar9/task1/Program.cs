// Задача 67: Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int a = 453;
// int sum = 0;
// int RecSumNumbers(int a)
// {
//     if (a==0)
//     {
//         return sum;
//     }
//     else
//     {
//         sum = sum + a%10;
//         RecSumNumbers(a/10);
//         return sum;
//     }
// }
// RecSumNumbers(a);
// Console.WriteLine(sum);

int RecSumNumbers(int a)
{
    if (a == 0)
    {
        return 0;
    }
    else
    {
        return a%10 + RecSumNumbers(a/10);
    }
}
Console.WriteLine(RecSumNumbers(124));