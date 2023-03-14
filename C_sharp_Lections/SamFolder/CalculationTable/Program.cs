char [] array = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'};
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < 8; j++)
    {
        Console.Write($"{array[i]}{j}; ");
    }
    Console.WriteLine();
}
