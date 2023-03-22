//new

// int [] Array(int [,] matrix)
// {
//   int k =0;
//   int [] newArray = new int [matrix.GetLength(0)*matrix.GetLength(1)];
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//      for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       newArray[k]= matrix [i,j];
//       k++;
//      }
//   }
//   return newArray;
// }


// int [] SortArray(int [] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
// {
//     int minPosition = i;
//     for (int j = i + 1; j < array.Length; j++)
//     {
//         if (array[j] < array [minPosition])
//         {
//             minPosition = j;
//         }
//     }
//     int temp = array[i];
//     array[i] = array[minPosition];
//     array[minPosition] = temp;
// }
// return array;
// }

// Console.WriteLine();
// int [] newArray = Array(matrix);
// Console.WriteLine(String.Join(", ", newArray));
// SortArray(newArray);
// Console.WriteLine(String.Join(", ", newArray));

