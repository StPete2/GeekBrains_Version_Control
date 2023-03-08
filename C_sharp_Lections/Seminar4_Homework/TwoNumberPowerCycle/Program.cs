// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int InputNumber()
{
    Console.WriteLine("Введите натуральное число");
    return Convert.ToInt32(Console.ReadLine());
}
int Power(int number, int power)
{
    int result;
    if (power == 0)
    {
        Console.WriteLine("Число в степени 0 всегда равно 1");        
        result = number / number;
        return result;
    }
    else if (power == 1)
    {
        Console.WriteLine("Число в степени 1 всегда равно самому числу");
        result = number;
        return result;
    }
    else
    {
        result = number;
        for (int variable = 2; variable <= power; variable ++)
        {
            result = result * number;        
        }   
        Console.WriteLine($"Число {number} в степени {power} равно {result}");
        return result;                
    }     
}
int a = InputNumber();
int b = InputNumber();
int c = Power(a,b);
//Console.WriteLine(c);