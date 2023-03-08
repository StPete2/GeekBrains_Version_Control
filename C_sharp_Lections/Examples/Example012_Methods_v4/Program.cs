// Вид 4: принимает и возвращает
// Вариант 1, Вид 4:
string Method4(int count, string text) 
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text + " ";
        i++;
        Console.WriteLine(result + " " + "7");//введено мной для лучшего понимания метода!
    }
    return result;
}
//string res = Method4(10, "asdf");
//Console.WriteLine(res);
Method4(6, "asdf"); // не дает нам вывод никакой! что интересно!
Console.WriteLine();
Console.WriteLine(Method4(6, "asdf"));

// Вариант 2, Вид 4:
// string Method4(int count, string text)
// {
//     string result = string.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

