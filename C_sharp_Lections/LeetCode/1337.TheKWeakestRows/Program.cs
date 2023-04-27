int [] KWeakestRows(int[,]mat, int k)
{
    int [] soldiersCount= new int[mat.GetLength(0)];

    for (int i = 0; i < mat.GetLength(0); i++)
    {
        int count = 0;
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if (mat[i,j]==1)
            {
                count ++;
            }
            else
            {
                break;
            }
            soldiersCount[i] = count;
            // Console.WriteLine("Empty line");
            // Console.WriteLine(count);
        }
        // {
        //     count = count + mat[i,j];
        // }        
        // soldiersCount[i] = count;
        // Console.WriteLine(count);
    }
        
    int [] kWeakestRows = new int [k];    
    for (int i = 0; i < k; i++)
    {
        int minPosition = 0;
        int maxPosition = 0;
        for (int j = 0; j < soldiersCount.Length; j++)
        {
            if (soldiersCount[j] < soldiersCount[minPosition])
            {
                minPosition = j;
            }
            if (soldiersCount[j] > soldiersCount[maxPosition])
            {
                maxPosition = j;
            }           
        }
        kWeakestRows[i] = minPosition;        
        soldiersCount[minPosition]+=soldiersCount[maxPosition]+1;
        // int temp = soldiersCount[i];
        // soldiersCount[i] = soldiersCount[minPosition];
        // soldiersCount[minPosition]=temp;
    }
    return kWeakestRows;
}
int[,] mat = new int [,] {
    {1,1,0,0,0},
    {1,1,1,1,0},
    {1,0,0,0,0},
    {1,1,0,0,0},
    {1,1,1,1,1}
    };
//int k = 3;
int [,] mat2 = new int [,]{
    {1,0},
    {1,0},
    {1,0},
    {1,1}
};
int k2 = 4; 
int [] result = KWeakestRows(mat2, k2);
Console.WriteLine(String.Join(" ", result));