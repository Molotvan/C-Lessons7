int m = 5;
int n = 6;

double[,] randoms = new double[m, n];

FillArray(randoms);

PrintArray(randoms);

void FillArray(double[,] randoms)
{
    Random random = new Random();
    for (int i = 0; i < randoms.GetLength(0); i++)
    {
        for (int j = 0; j < randoms.GetLength(1); j++)
        {
            randoms[i, j] = random.NextDouble();
        }
    }
}

void PrintArray(double[,] randoms)
{
    for (int i = 0; i < randoms.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < randoms.GetLength(1); j++)
        {
            Console.Write(Math.Round(randoms[i, j], 3) + " ");
        }
    }
}
