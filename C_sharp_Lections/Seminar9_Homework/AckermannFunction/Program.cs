// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Prompt (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int AckermannFunction(int n, int m)
{
    if (n == 0)
    {
        return m+1;
    }
    else if (m == 0)
    {
        return AckermannFunction(n-1,1);
    }
    else
    {
        return AckermannFunction(n-1,AckermannFunction(n,m-1));
    }
}
int n = Prompt("Введите неотрицательное число не больше 3");
int m = Prompt("Введите неотрицательное число не больше 4");
int c = AckermannFunction(n,m);
Console.WriteLine("Результат функции Аккермана для двух чисел выше равен: " + c);