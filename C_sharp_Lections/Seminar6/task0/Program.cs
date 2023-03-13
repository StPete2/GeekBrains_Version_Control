int Prompt(string text)
{
    Console.WriteLine("Введите целое десятичное число");
    return Convert.ToInt32(Console.ReadLine());
}

// int DecToBin(int dec)
// {
//     int delitel = 2;
//     while (dec >= delitel)
//     {
//         if (dec % 2 == 0)
//         {
//             dec = dec / delitel;
//             Console.Write("0");            
//         }
//         else
//         {
//             dec = dec / delitel;
//             Console.Write("1");
//         }        
//     }
//     if (dec == 1)
//     {
//         Console.Write("1");
//         //array[index]=1;
//     }
//     else
//     {
//         Console.Write("0");
//         //array[index]=0;
//     }

// }
// Console.WriteLine();
// Console.WriteLine("Число успешно переведено в бинарное");
// //Console.WriteLine("Бинарное число = " + array[]);

string NewFuction(int dec)
{
    string result = string.Empty;
    while (dec > 0)
    {
        result = Convert.ToString(dec%2) + result;
        dec = dec/2;
    }
    return result;
}
string a = NewFuction(Prompt("Введите натуральное десятичное число"));
Console.WriteLine(a);

// int[] GetArray()

// {

//     Console.WriteLine("Введите  размер массива: ");

//     int arraySize = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Задайте пределы перебора случайных чисел. Нижняя граница: ");

//     int randomLow = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Задайте пределы перебора случайных чисел. Верхняя граница: ");

//     int randomHigh = Convert.ToInt32(Console.ReadLine());

//     int[] array = new int[arraySize];

//     for (int i = 0; i < array.Length; i++)

//     {

//         array[i] = new Random().Next(randomLow,randomHigh);

//     }

//     return array;

// }

// int[] array = GetArray();

// Console.WriteLine(String.Join(" | ", array));