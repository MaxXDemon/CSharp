int ChekingNumber() //Метод осуществляет проверку введенной в консоль строки на предмет числа
{
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        return number;
    }
    else throw new ArgumentException("Вы ввели не число");
}

void CreateAndPrintArrayNaturalNumbers(int numberColumns, int numberRows) // Метод создает и наполняет двухмерный массив натуральными числами, а так же выводит его в консоль
{
    double[,] array = new double[numberColumns, numberRows];

    for (int i = 0; i < numberColumns; i++)
    {
        for (int j = 0; j < numberRows; j++)
        {
            double element = new Random().Next(-100, 100);
            array[i, j] = element / 10;
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}

int[,] CreateAndPrintArrayIntegers() //Метод создает и наполняет двухмерный массив целыми числами, а так же выводит его в консоль
{
    int[,] array = new int[4, 5];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int element = new Random().Next(0, 10);
            array[i, j] = element;
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Введите координаты элемента (Первое число - индекс колонки, Второе число - индекс строки");
    return array;

}

void SearchElement(int[,] array, int numberColumns, int numberRows)//Метод осуществляет поиск нужного элнмента, по указанным в консоль координатам (Строка, Столбец)
{
    if ((numberColumns < array.GetLength(0)) && (numberRows < array.GetLength(1)))
        Console.WriteLine($"На данной позиции находится элемент:{array[numberColumns, numberRows]} ");
    else
        Console.WriteLine("Такой позиции нет в массиве");
}

void ArithmeticMean(int[,] array)//Метод высчитывает среднее арифметичсекое по каждому столбцу
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summ = 0;
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ += array[i, j];
            count++;
        }
        Console.WriteLine($"Среднее арифметическое {j} столбца равно: {summ = summ / (count)}");

    }
}

Console.WriteLine("Введите номер задачи (1 из 3):");

switch (ChekingNumber())
{
    case (1):
        Console.WriteLine("Введите размер двумерного массива");
        CreateAndPrintArrayNaturalNumbers(ChekingNumber(), ChekingNumber());
        break;

    case (2):
        SearchElement(CreateAndPrintArrayIntegers(), ChekingNumber(), ChekingNumber());
        break;

    case (3):
        ArithmeticMean(CreateAndPrintArrayIntegers());
        break;

}
