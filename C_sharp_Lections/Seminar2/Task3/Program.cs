Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number%7==0 && Number%23==0)
{
    Console.WriteLine("Введенное число кратно 7 и 23 одновременно");    
}
else Console.WriteLine("Введенное число не кратно 7 и 23 одновременно");