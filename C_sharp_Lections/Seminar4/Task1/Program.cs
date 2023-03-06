// Задача 26: Напишите программу, которая принимает на вход число и выдаёт 
// количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120*/
int Prompt()
{
    Console.WriteLine("Введите число");
    return Convert.ToInt32(Console.ReadLine());
}

int NumQuantity(int number)
{
    int i = 1;
    while (number /10!=0)
    {
        number /= 10;
        i ++;
    }
    return i;
}
int a = Prompt();
//Console.WriteLine(NumQuantity(a));

int NumMultiply (int number)
{
    int multiply = 1;
    //int i = 1;
    // while (i <= number)
    // {
    //     mulitply = mulitply*i;
    //     i = i + 1;
    // }
    for (int i = 1; i <=number; i++)
        multiply *= i;
    return multiply;
}
Console.WriteLine(NumMultiply(a));