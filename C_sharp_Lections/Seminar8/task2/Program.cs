int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] CreateOutputCopyArray(int m, int n)
{
    int [,] array = new int [m,n];
    // int [,] newArray = new int [m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,11);
            //newArray[i,j] = array [i,j];
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}
int m = Prompt("Введите количество строк");
int n = Prompt("Введите количество столбцов");

Console.WriteLine();
int [,] array = CreateOutputCopyArray(m,n);
Console.WriteLine();

int [] TDAinODA (int [,]array)
{
    int k = 0;
    int [] newArray = new int [array.GetLength(0)*array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[k] = array[i,j];
            k++;
        }
    }
    return newArray;
}

int [] SortArray(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
    return array;
}

int [] newArray = TDAinODA(array);
Console.WriteLine(String.Join(", ", newArray));
SortArray(newArray);
Console.WriteLine();
Console.WriteLine(String.Join(", ", newArray));


// int count = 1;
// for (int i = 0; i < newArray.Length-1; i++)
// {
//     if (newArray[i] == newArray[i + 1])
//     {
//         count++;
//         int a = i;
//     }
//     else
//     {
//         Console.WriteLine($"Элемент {newArray[i]} встречается в массиве {count} раз");
//         count = 1;
//     }
// }

int el = newArray[0];
int count = 1;
for (int i = 1; i < newArray.Length; i++)
{
    if (el == newArray[i])
    {
      count ++;
    }
    else
    {
      Console.WriteLine($"Число {el} встречается в массиве {count} раз");
      count = 1;
      el = newArray[i];
    }
}
Console.WriteLine($"Число {el} встречается в массиве {count} раз");