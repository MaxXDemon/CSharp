int ChekingNumber()
{
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        return number;
    }
    else throw new ArgumentException("Вы ввели не число");
}

int[,] CreateAndPrintArray(int numberColumns, int numberRows)
{
    int[,] array = new int[numberColumns, numberRows];
    for (int i = 0; i < numberColumns; i++)
    {
        for (int j = 0; j < numberRows; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

void EvenIndexesSquared(int[,] array)
{
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                summ += array[i,j];
            }
            
        }
        
    }
    Console.Write($"Сумма элекментов равна {summ}");
}

    Console.WriteLine("Введите размер двумерного массива");
    EvenIndexesSquared(CreateAndPrintArray(ChekingNumber(), ChekingNumber()));
