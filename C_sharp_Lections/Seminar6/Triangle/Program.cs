int InputNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int a = InputNumber("Введите длину первой стороны треугольника");
int b = InputNumber("Введите длину второй стороны треугольника");
int c = InputNumber("Введите длину третьей стороны треугольника");

if (a + b > c && b + c > a && c + a > b)
{
    Console.WriteLine("Такой треугольник существует");
}
else
{
    Console.WriteLine("Такого треугольника не существует");
}