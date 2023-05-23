int Fibonacci(int n)
{
    if (n == 0)
    {
        return 0;
    }
    else if (n == 1)
    {
        return 1;
    }
    else
    {
        int fib0 = 0;
        int fib1 = 1;
        int fib2;
        for (int i = 2; i <= n; i++)
        {
            fib2 = fib1+fib0;
            fib0=fib1;
            fib1 = fib2;
        }
        return fib1;        
    }
}
Console.Write("Введите число Фибоначчи: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Fibonacci(n);
Console.WriteLine(m);