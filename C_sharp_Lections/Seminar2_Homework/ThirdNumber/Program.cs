Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number/100 == 0)
{
    Console.WriteLine("Вы ввели однозначное или двухзначное число, а именно: " + number);
    Console.WriteLine("Третьей цифры в этом числе нет.");
}
else if (number/1000!=0)
{
    int firstinterim = number%1000;
    int thirddigit = firstinterim/100;
    Console.WriteLine("Третьей цифрой в числе {1} является {0}", thirddigit, number);
}
else
{
    int thirddigit = number/100;
    Console.WriteLine("Третьей цифрой в числе {1} является {0}", thirddigit, number);
}