int romanToInt(string s)
{
    var dictionary = new Dictionary<char, int>
    {
        {'I',1}, {'V', 5 }, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
    };
    int sum = dictionary[s.LastOrDefault()];
    for (int i = s.Length-2; i >= 0; --i)
    {
        if (dictionary[s[i]]<dictionary[s[i+1]])
        {
            sum = sum - dictionary[s[i]];
        }
        else
        {
            sum = sum + dictionary[s[i]];
        }
    }
    return sum;
}

Console.WriteLine("Введите число римскими цифрами");
string s = Console.ReadLine();
int number = romanToInt(s);
Console.WriteLine(number);