// int romanToInt(string s)
// {
    
// }
// I             1
// V             5
// X             10
// L             50
// C             100
// D             500
// M             1000
int romanToInt(string s)
{
    var dictionary = new Dictionary<char, int>
    {
        {'I',1}, {'V', 5 }, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
    };
    
    s=s.Replace("IV", "IIII");
    s = s.Replace("IX", "VIIII");
    s = s.Replace("XL", "XXXX");
    s = s.Replace("XC", "LXXXX");
    s = s.Replace("CD", "CCCC");
    s = s.Replace("CM", "DCCCC");

    int result = 0;
    //char [] array = s.ToCharArray();
    foreach (var el in s)
    {
        result = result + dictionary[el];                
    }
    return result;
}
Console.WriteLine("Введите число римскими цифрами");
string s = Convert.ToString(Console.ReadLine());
int number = romanToInt(s);
Console.WriteLine(number);