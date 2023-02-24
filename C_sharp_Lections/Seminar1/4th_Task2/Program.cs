Console.WriteLine("Введите целое число");
int Num = Convert.ToInt32(Console.ReadLine());
int NumNegative = Num * (-1);
while (NumNegative <= Num)
{
    Console.Write(NumNegative + " ");
    NumNegative = NumNegative + 1;
}
