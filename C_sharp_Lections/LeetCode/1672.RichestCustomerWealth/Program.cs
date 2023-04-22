int MaximumWealth(int[,] accounts) 
{
    int wealth = 0;
    for (int i = 0; i < accounts.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < accounts.GetLength(1); j++)
        {
            sum = sum + accounts[i,j];
        }
        if (sum > wealth)
        {
            wealth = sum;
        }
    }
    return wealth;
}
