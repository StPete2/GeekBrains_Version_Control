Console.WriteLine("Введите целое число");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number %2 == 0 && Number != 0)
{
    Console.WriteLine("Число чётное");
}
else if (Number ==0)
{
    Console.WriteLine("Число равно нулю");
}
else Console.WriteLine("Число нечётное");