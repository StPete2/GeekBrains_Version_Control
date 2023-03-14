string input = string.Empty;
Console.WriteLine("Введите десятичное число");
int num = Convert.ToInt32(Console.ReadLine());
while (num > 0)
{
    input = num%2 + input;
    num = num/2;
}
Console.WriteLine(input);

// string Reverse (string input)
// {
//     char [] charArray = input.ToCharArray();
//     Array.Reverse(charArray);
//     return new string(charArray);
// }
// Console.WriteLine(Reverse(input));