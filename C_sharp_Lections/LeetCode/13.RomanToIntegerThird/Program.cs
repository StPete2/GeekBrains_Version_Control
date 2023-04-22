int romanToInt(string s)
{
    var dictionary = new Dictionary<char, int>
    {
        {'I',1}, {'V', 5 }, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
    };
    int result = 0;
    int intVal, nextIntVal;

    for (int i = 0; i < s.Length; i++)
    {
        intVal = dictionary[s[i]];

        if (i != s.Length - 1)
        {
            nextIntVal = dictionary[s[i + 1]];

            if (nextIntVal > intVal)
            {
                intVal = nextIntVal - intVal;
                i++;                
            }
        }
        result = result + intVal;
    }
    return result;
}
Console.WriteLine("Введите число римскими цифрами");
string s = Convert.ToString(Console.ReadLine());
int number = romanToInt(s);
Console.WriteLine(number);
