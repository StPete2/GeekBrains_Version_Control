Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number >=1 && number <=7)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("День является выходным");        
    }
    else
    Console.WriteLine("День является рабочим");
}
else
Console.WriteLine("Введите номер дня недели от 1 до 7");