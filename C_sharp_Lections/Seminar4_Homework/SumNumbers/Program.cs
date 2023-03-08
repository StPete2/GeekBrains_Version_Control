// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int InputNumber()
{
    Console.WriteLine("Введите натуральное число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
//int digitCount = (int)Math.Log10(number) + 1;
// int i = 1;
// int sum = 0;
// while (i <= digitCount)
// {
//     sum = sum + number %10;
//     number = number/10;
//     i ++;
// }
// Console.WriteLine("Сумма всех цифр числа равна: " + sum);
int a = InputNumber();
int SumNumbers(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number%10;
        number = number /10;
    }
    return result;    
}
Console.WriteLine($"Сумма всех цифр в числе {a} равна: " + SumNumbers(a));