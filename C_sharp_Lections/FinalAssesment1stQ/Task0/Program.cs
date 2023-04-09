// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.WriteLine("Введите строку из слов или символов через пробел");
string s = Convert.ToString(Console.ReadLine());
string [] stringArray = s.Split(' ');
int count3orLessCharNum = 0;
int [] numberOfCharacters = new int [stringArray.Length];
int i = 0;
foreach (var item in stringArray)
{
    numberOfCharacters[i] = item.Length;
    if (numberOfCharacters[i]<=3)
    {
        count3orLessCharNum ++;
    }
    i++;
}
string [] resultArray = new string [count3orLessCharNum];

i=0;
int j =0;
foreach (var item in stringArray)
{
    if (numberOfCharacters[i]<=3)
    {
        resultArray[j] = item;
        j++;
    }
    i++;
}

Console.WriteLine(count3orLessCharNum);
Console.WriteLine(String.Join(" ", numberOfCharacters));
Console.WriteLine(String.Join(" ", resultArray));