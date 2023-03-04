Console.WriteLine("Введите число");
string number = Console.ReadLine();
int result;
if (int.TryParse(number, out result))
{
    Console.WriteLine("Вы ввели число");
}
else
{
    Console.WriteLine($"Вы ввели не числовое значение {number}");
}