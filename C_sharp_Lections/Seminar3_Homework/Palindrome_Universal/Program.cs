Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int digitCount = (int)Math.Log10(number) + 1;
int[] array = new int [digitCount];
int interim = number;
int index = 0;
int power = 0;
double newnum = 0;
while (index < digitCount)
{
    array[index] = number%10;
    number = number/10;
    index = index + 1;    
}
index = digitCount - 1;
while (index >= 0)
{
    newnum = newnum + array[index]*Math.Pow(10,power);
    index = index - 1;
    power = power + 1;
}
if (newnum == interim)
{
    Console.WriteLine("Число является палиндромом");    
}
else
{
    Console.WriteLine("Число не является палиндромом");
}