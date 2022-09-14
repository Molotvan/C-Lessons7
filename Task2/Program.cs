
int[,] numbers = new int[5, 4];
FillArray(numbers);
Console.WriteLine("Введите по очереди номер строки а затем столбца");

int row = Int32.Parse(Console.ReadLine());
int column = Int32.Parse(Console.ReadLine());
if (row >= numbers.GetLength(0) || column >= numbers.GetLength(1))
{
    Console.WriteLine("Такой ячейки не существует");
}
else Console.WriteLine(numbers[row, column]);

void FillArray(int[,] randoms)
{
    Random random = new Random();
    for (int i = 0; i < randoms.GetLength(0); i++)
    {
        for (int j = 0; j < randoms.GetLength(1); j++)
        {
            randoms[i, j] = random.Next();
        }
    }
}