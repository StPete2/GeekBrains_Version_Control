// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и 
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Prompt (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int RecPower(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    else
    {
        return a*RecPower(a, b-1);
    }
}
int a = Prompt("Введите основание степени");
int b = Prompt("Введите степень");
Console.WriteLine(RecPower(a,b));