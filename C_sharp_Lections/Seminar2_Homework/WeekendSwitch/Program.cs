Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
    Console.WriteLine("День является рабочим");
    break;
    case 2:
    Console.WriteLine("День является рабочим");
    break;
    case 3:
    Console.WriteLine("День является рабочим");
    break;
    case 4:
    Console.WriteLine("День является рабочим");
    break;
    case 5:
    Console.WriteLine("День является рабочим");
    break;
    case 6:
    Console.WriteLine("Выходной день!");
    break;
    case 7:
    Console.WriteLine("Выходной день!");
    break;
    default:
    Console.WriteLine("Такого дня недели не существует. Введите цифру от 1 до 7");
    break;
}
