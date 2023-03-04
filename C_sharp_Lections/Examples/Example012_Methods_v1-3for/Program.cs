// Вид 1 (ничего не принимают, ничего не возвращают)
void Method1()
{
    Console.WriteLine("Автор Лёша");
}
Method1();

// Вид 2 (принимают, не возвращают)
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");
//или можно написать так:
Method2(msg: "Текст сообщения2");

//Вариант 2, вида 2 (принимают, не возвращают)
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.Write(msg);
        i ++;
    }
}
Method21("Текст", 4);
//Или можно вывести так (тогда в любом порядке можно записывать)
Method21(msg: "Текст2", count: 4);

// Вид 3: не принимает, но возвращает
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// for loop
for (int i = 2; i<=10; i++)
{
    for (int j=2; j<=6; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}