Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number/100 == 0)
{
    Console.WriteLine("Вы ввели однозначное или двухзначное число, а именно: " + number);
}
// else if ()
// {
    
// }
else
{
    int thirddigit = number/100;
    Console.WriteLine("Третьей цифрой в числе {1} является {0}", thirddigit, number);
}