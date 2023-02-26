int Delitel = 2;
Console.WriteLine("Введите целое десятичное число");
int Dec = Convert.ToInt32(Console.ReadLine());
//int[] array = new int [10];
//int index = 0;
while (Dec>=Delitel)
{
    if (Dec %2 == 0)
    {
        Dec = Dec / Delitel;
        Console.Write ("0");
  //      array[index] = 0;
    }
    else
    {
        Dec = Dec / Delitel;
        Console.Write("1");
  //      array[index] = 1;
    }
    //index = index + 1;
}
if (Dec == 1)
{
    Console.Write("1");
    //array[index]=1;
} 
else
{
    Console.Write("0");
    //array[index]=0;
}
Console.WriteLine();
Console.WriteLine("Число успешно переведено в бинарное");
//Console.WriteLine("Бинарное число = " + array[]);