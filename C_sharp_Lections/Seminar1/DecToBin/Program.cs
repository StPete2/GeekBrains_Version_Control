int Delitel = 2;
Console.Write("Введите десятичное число ");
double Dec = Convert.ToInt32(Console.Read());
while (Dec>=Delitel)
{
    if (Dec %2 == 0);
    {
        Dec = Dec / Delitel;
        Console.Write ("0");
    };
    else
    {
        Dec = Dec / Delitel;
        Console.Write("1");
    }
    
}
Console.Write("1");
