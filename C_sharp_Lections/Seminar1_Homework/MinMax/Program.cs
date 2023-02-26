Console.WriteLine("Введите первое целое число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber > SecondNumber)
{
    Console.WriteLine("Первое число больше второго.");
    Console.WriteLine(FirstNumber + " - это большее, а " + SecondNumber + " - это меньшее.");   
}
else
{
    Console.WriteLine("Второе число больше первого.");
    Console.WriteLine(SecondNumber + " - это большее, а " + FirstNumber + " - это меньшее.");
}