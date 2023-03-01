Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    Console.WriteLine("Вы ввели следующее трехзначное число: " + number);
    int firstinterim = number/10;
    int seconddigit = firstinterim%10;
    Console.WriteLine("Вторая цифра этого трехзначного числа равняется: " + seconddigit);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}