// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
int InputNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
// int a = InputNumber();
// int b = InputNumber();

int Random(string name, int min, int max)
{
    int number = new Random().Next(min,max);
    return number;
}
string maximal = "Введите максимальное значение";
string minimal = "Введите минимальное значение";
int max2 = InputNumber(maximal);
int min2 = InputNumber(minimal);
string abc = "Love";
//string def = "Peace";
// int c = Random(abc,40,50);
// int d = Random(def,1,10);
int e = Random(abc,min2,max2);

//int powerbase = InputNumber("Введите что-нибудь ...");
