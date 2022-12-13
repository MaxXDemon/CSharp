int ChekingNumber()
{
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        return number;
    }
    else throw new ArgumentException("Вы ввели не число");
}

void CreateAndPrintArray(int numberColumns, int numberRows)
{
    double[,] array = new double [numberColumns, numberRows];
    for (int i = 0; i < numberColumns; i++)
    {
        for (int j = 0; j < numberRows; j++)
        {
            double element = new Random().Next(-100, 100);
            array[i, j] = element/10;
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите размер двумерного массива");
CreateAndPrintArray(ChekingNumber(), ChekingNumber());