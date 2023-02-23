Console.WriteLine("Введите первое число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber == SecondNumber*SecondNumber)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{    
    Console.WriteLine("Первое число не является квадратом второго");
}

