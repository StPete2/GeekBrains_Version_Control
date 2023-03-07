int InputNumber()
{
    Console.WriteLine("Введите степень");
    return Convert.ToInt32(Console.ReadLine());
}

int Random()
{
    int number = new Random().Next(5,10);
    return number;
}

double Power(int number, int power)
{
    double result = Math.Pow(number, power);
    return result;
}
int a = Random();
int b = InputNumber();
Console.WriteLine($"Случайное число {a}, возведенное в степень {b} равно {Power(a,b)}");
