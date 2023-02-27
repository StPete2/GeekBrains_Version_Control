Console.WriteLine("Введите первое число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
// if (FirstNumber%SecondNumber == 0)
// {
//     Console.WriteLine("Первое число кратно первому");
// }
// else 
// {
//     Console.WriteLine($"Первое число не кратно первому. Остаток от деления = {FirstNumber%SecondNumber}");    
// }
string result = FirstNumber%SecondNumber == 0? "Второе число кратно первому":$"Второе число не кратно первому. Остаток от деления = {FirstNumber%SecondNumber}";
