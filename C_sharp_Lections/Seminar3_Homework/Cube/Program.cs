// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел 
//от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number} - > ");
for (int count = 1; count <=number; count++)
{
    double result = Math.Pow(count, 3);
    Console.Write($"{result} ");    
}
Console.WriteLine("\nВы успешно вывели в консоль список кубов чисел от 1 до " + number);