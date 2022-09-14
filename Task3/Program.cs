
int[,] numbers = new int[4, 5];

FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();
double[] averages = CountAverage(numbers);
Console.WriteLine();
Console.WriteLine("{0}", string.Join("; ", averages));

void FillArray(int[,] randoms)
{
    Random random = new Random();
    for (int i = 0; i < randoms.GetLength(0); i++)
    {
        for (int j = 0; j < randoms.GetLength(1); j++)
        {
            randoms[i, j] = random.Next(1, 10);
        }
    }
}


double[] CountAverage(int[,] numbers)
{
    double[] averages = new double[numbers.GetLength(1)];
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < numbers.GetLength(0); j++)
        {
            sum = sum + (double)numbers[j, i];
        }
        averages[i] = sum / numbers.GetLength(0);
    }

    return averages;
}

void PrintArray(int[,] randoms)
{
    for (int i = 0; i < randoms.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < randoms.GetLength(1); j++)
        {
            Console.Write(randoms[i, j] + "    ");
        }
    }
}
