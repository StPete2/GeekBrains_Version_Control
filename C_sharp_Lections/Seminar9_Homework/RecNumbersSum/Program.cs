// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int Prompt (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int RecNumbersSum (int m, int n)
{
    if (m == n)
    {
        return n;
    }
    else if (m>n)
    {
        return n + RecNumbersSum(m, n+1);
    }
    else
    {
        return m + RecNumbersSum(m + 1, n);
    }
}
int m = Prompt("Введите первое число");
int n = Prompt("Введите второе число");
Console.WriteLine($"Сумма натуральных чисел от m до n составляет: {RecNumbersSum(m,n)}");