// Задача 65: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int m = 1;
int n = 5;
void RecNumbers (int m, int n)
{
    if (m == n)
    {
        Console.Write(m);
    }
    else
    {
        Console.Write(m + " ");
        RecNumbers(m+1, n);
    }
}
RecNumbers(m,n);