string [] FizzBuzz (int n)
{
    string [] answer = new string [n];
    // var dictionary = new Dictionary <int, string>
    // {
    //     {'1', "Fizz"}, {'2', "Buzz"}, {'3', "FizzBuzz"}
    // };
    for (int i = 1; i <= n; i++)
    {
        if (i%3 == 0 && i%5==0)
        {
            answer[i-1] = "FizzBuzz";
        }
        else if (i%3 == 0)
        {
            answer[i-1] = "Fizz";
        }    
        else if (i%5 == 0)
        {
            answer[i-1]= "Buzz";
        }
        else
        {
            answer[i-1] = Convert.ToString(i);
        }
    }
    return answer;
}
int n = 15;
string []answer = FizzBuzz(n);
Console.WriteLine(String.Join(", ", answer));
