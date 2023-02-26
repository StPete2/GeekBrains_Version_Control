Console.WriteLine("Введите первое целое число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());

int Max = FirstNumber;

if (SecondNumber > Max)
{
    Max = SecondNumber;
}
if (ThirdNumber > Max)
{
    Max = ThirdNumber;
}

Console.WriteLine();
//Console.WriteLine("Максимальное число из трех: " + Max);
string A = "первое число";
if (Max == FirstNumber)
{
    A = "первое число";
}
if (Max == SecondNumber)
{
    A = "второе число";
}
if (Max == ThirdNumber)
{
    A = "третье число";
}
Console.WriteLine("Максимальное число из трех: " + Max + ". Это " + A + ", которое Вы ввели.");