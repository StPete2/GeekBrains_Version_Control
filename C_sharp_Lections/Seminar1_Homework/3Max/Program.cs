Console.WriteLine("Введите первое целое число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (SecondNumber > max)
{
    SecondNumber = max;
}
else if (ThirdNumber > max)
{
    ThirdNumber = max;
}
Console.WriteLine();
Console.WriteLine("Максимальное число из трех: " + max);