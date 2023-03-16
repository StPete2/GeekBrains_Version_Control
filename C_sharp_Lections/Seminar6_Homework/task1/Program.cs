// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// https://www.cyberforum.ru/turbo-pascal/thread691145.html
const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int LINE1 = 1;
const int LINE2 = 2;


double Prompt(string text)
{
    Console.WriteLine(text);
    string value = Console.ReadLine();
    return Convert.ToDouble(value);
}

double [] InputLineData(int numberOfLine)
{
    double [] lineData = new double [2];
    lineData[COEFFICIENT] = Prompt($"Введите коэффициент для {numberOfLine} прямой");
    lineData[CONSTANT] = Prompt($"Введите константу для {numberOfLine} прямой");
    return lineData;
}

double [] lineData1 = InputLineData(LINE1);
double [] lineData2 = InputLineData(LINE2);