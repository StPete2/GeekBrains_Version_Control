Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int size = 5;
int[] array = new int [size];
int interim = number;
int index = 0;
int step = 0;
double newnum = 0;
if (number > 9999 && number < 100000)
{
    while (index < size)
    {
        array[index] = number%10;
        number = number /10;
        index = index + 1;
    }
    index = 4;
    while (index >= 0)
    {
        newnum = newnum + array[index]*Math.Pow(10,step);
        index = index - 1;
        step = step + 1;
    }
    if (newnum == interim)
    {
        Console.WriteLine($"Число {interim} является паралиндромом");
    }
    else
    {
        Console.WriteLine($"Число {interim} не является паралиндромом");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}