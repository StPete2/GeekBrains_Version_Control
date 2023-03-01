Console.WriteLine("Введите первое число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber*FirstNumber == SecondNumber)
{
    Console.WriteLine("Второе число является квадратом первого");    
}
else if (SecondNumber*SecondNumber == FirstNumber)
{
    Console.WriteLine("Первое число является квадратом второго");    
}
else Console.WriteLine("Ни первое, ни второе число не являются квадратом друг друга");
//Console.WriteLine($"{num / 100}{num % 10}");