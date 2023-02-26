Console.WriteLine("Введите целое число");
int Number = Convert.ToInt32(Console.ReadLine());
int correction = 1;
int step = 2;
int start = 1;
int count = 0;
if (Number ==1)
{
    Console.WriteLine("В заданном промеждутке от 1 до " + Number + " чётных чисел нет");
}
else if (Number <=0)
{
    Console.WriteLine("Вы задали некорректный промеждуток. Введите число больше 1");
}
else
{
    start = start + correction;
    while (start <= Number)
    {
        Console.Write(start + " ");
        start = start + step;
        count = count + 1;
    }
Console.WriteLine();
Console.WriteLine("Список всех чётных чисел от 1 до " + Number + " составлен.");
Console.WriteLine("Всего четных чисел: " + count);
}
