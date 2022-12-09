
int CheckNumber()
{
    if (int.TryParse(Console.ReadLine(), out int number))
        return number;
    else throw new ArgumentException("Вы ввели не число");
}

double [] FillArray(double [] array)
{
    Console.Write("Массив: ");
    for (int id = 0; id < array.Length; id++)
    {
        array[id] = new Random().NextDouble() + new Random().Next(0, 10);
        Console.Write($" {array[id]}");
    }
    Console.WriteLine();
    return array;
}

void SearchMinMax(double [] array)
{
    double minNumber = array[0];
    double maxNumber = array[0];
    double result = 0;
    for (int id = 1; id < array.Length; id++)
    {
        if (array[id]<minNumber) minNumber=array[id];
        if (array[id]>maxNumber) maxNumber=array[id];    
    }
    result = maxNumber-minNumber;
    Console.WriteLine($"Максимальное значение в массиве: {maxNumber}");
    Console.WriteLine($"Минимальное значение в массиве: {minNumber}");
    Console.WriteLine($"Разница: {result}");
}



Console.WriteLine("Введите количество элементов в массиве:");
double [] array = new double[CheckNumber()];

SearchMinMax(FillArray(array));

