Console.WriteLine("Введите номер дня недели");
int Weekday = Convert.ToInt32(Console.ReadLine());
if (Weekday <8 && Weekday >0)
{
    if (Weekday == 1)
       Console.WriteLine("Понедельник");
    else if (Weekday == 2)
       Console.WriteLine("Вторник");
    else if (Weekday == 3)
        Console.WriteLine("Среда");
    else if (Weekday == 4)
        Console.WriteLine("Четверг");
    else if (Weekday == 5)
        Console.WriteLine("Пятница");
    else if (Weekday == 6)
        Console.WriteLine("Суббота");
    else if (Weekday == 7) 
        Console.WriteLine("Воскресенье");
}
else 
{ 
       Console.WriteLine("Введите число от 1 до 7");
}

