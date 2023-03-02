Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int number2 = number;
while (number2/10!=0)
{
    number2 = number2/10;
    count = count + 1;
}
int[] massive = new int[count];

if (number > 9999 && number < 100000 || number > -100000 && number < -9999)
{
    for (int countopposite = 0; countopposite < count; countopposite++)
    {
        int interim = number%10;
        massive[countopposite] = interim;
        number = number/10;        
    }
Console.WriteLine(massive);
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}