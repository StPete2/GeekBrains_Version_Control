int [,] CreateArray()
{
  int m = new Random().Next(2, 10);
  int n = new Random().Next(2, 10);
  int [,] matrix = new int [m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
    }
  
  }
  return matrix;
}

int [,] PrintArray(int [,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
            Console.Write(matrix[i, j] + "\t");
    }
  Console.WriteLine();
  }
  return matrix;
}


int [,] ChangeArray(int [,] matrix)
{
  int tmp = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      tmp = matrix[0, j];
      matrix[0, j]= matrix [matrix.GetLength(0)-1,j];
      matrix [matrix.GetLength(0)-1,j] = tmp;
   }
   return matrix;
}

int [,] matrix = CreateArray();
PrintArray (matrix);
Console.WriteLine();
PrintArray(ChangeArray(matrix));

//new
int [,] CreateArray()
{
  int m = new Random().Next(2, 10);
  int n = new Random().Next(2, 10);
  int [,] matrix = new int [m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
    }
  
  }
  return matrix;
}

int [,] PrintArray(int [,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
            Console.Write(matrix[i, j] + "\t");
    }
  Console.WriteLine();
  }
  return matrix;
}


int [] Array(int [,] matrix)
{
  int k =0;
  int [] newArray = new int [matrix.GetLength(0)*matrix.GetLength(1)];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
     for (int j = 0; j < matrix.GetLength(1); j++)
    {
      newArray[k]= matrix [i,j];
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
        if (array[j] < array [minPosition])
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

int [,] matrix = CreateArray();
PrintArray (matrix);
Console.WriteLine();
int [] newArray = Array(matrix);
Console.WriteLine(String.Join(", ", newArray));
SortArray(newArray);
Console.WriteLine(String.Join(", ", newArray));

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