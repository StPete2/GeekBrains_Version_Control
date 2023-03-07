// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
int Prompt()
{
    Console.WriteLine("Введите число");
    return Convert.ToInt32(Console.ReadLine());    
}

int SumNums(int number)
{
    int sum = 0;
    for (int i=1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}
//Prompt(); // тоже работает на ввод числа! но никуда не используется
int a = Prompt();
int b = Prompt();
Console.WriteLine($"{SumNums(a)}, текст тут {SumNums(b) + a}"); //тренировка вывода через $