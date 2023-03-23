// Задача 65: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int Prompt (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void RecNumbers (int m, int n)
{
    if (m == n)
    {
        Console.Write(n);
    }
    else if (m < n)
    {
        Console.Write(m + " ");
        RecNumbers(m+1, n);
    }
    else
    {
        Console.Write(n + " ");
        RecNumbers(m, n+1);
    }
}
int m = Prompt("Введите первое число");
int n = Prompt("Введите второе число");
RecNumbers(m,n);