﻿// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// https://www.cyberforum.ru/turbo-pascal/thread691145.html

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int LINE1 = 1;
const int LINE2 = 2;
const int X_COORD = 0;
const int Y_COORD = 1;

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

double [] FindCoords(double [] lineData1, double [] lineData2)
{
    double [] coord = new double [2];
    coord[X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) /
                     (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
    coord[Y_COORD] = lineData1[COEFFICIENT]*coord[X_COORD] + lineData1[CONSTANT];
    return coord;
}

if (ValidateLines(lineData1, lineData2))
{
    double [] coord = FindCoords(lineData1, lineData2);
    Console.Write("Точка пересечения уравнений ");
    Console.Write($"y ={ lineData1[COEFFICIENT]}*x + {lineData1[CONSTANT]} и ");
    Console.Write($"y = { lineData2[COEFFICIENT] }*x + { lineData2[CONSTANT]} ");
    Console.WriteLine($"имеет координаты ({coord[X_COORD]}, {coord[Y_COORD]})");       
}
bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
    {
        if (lineData1[CONSTANT] == lineData2[CONSTANT])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}