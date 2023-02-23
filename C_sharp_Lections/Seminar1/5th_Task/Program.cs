Console.WriteLine("Введите трехзначное число");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number > 99 && Number < 1000)
{
    Console.WriteLine(Number%10);
}
else 
{ 
    Console.WriteLine("Вы ввели не трехзначное число!");
}
