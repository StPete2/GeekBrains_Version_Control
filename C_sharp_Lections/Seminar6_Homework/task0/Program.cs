Console.WriteLine("Введите число или числа");
string input = Console.ReadLine();
char [] charArray = input.ToCharArray();
Console.WriteLine(String.Join("", charArray));
// int result;
// for (int i = 0; i < charArray.Length; i++)
// {
//     if (int.TryParse(charArray[i], out result))
//     {
//         Console.Write(result + " ");
//     }
//     else
//     {
//         Console.WriteLine("Чисел нет");
//     }
// }
