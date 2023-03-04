Console.WriteLine("Введите число");
string number = Console.ReadLine();
int result;
if (int.TryParse(number, out result) && number.Length > 2)
{
    Console.WriteLine(number[2]);
}
else
{
    Console.WriteLine("Ошибка");
}