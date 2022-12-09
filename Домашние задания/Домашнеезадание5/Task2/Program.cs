

int CheckNumber()
{
    if (int.TryParse(Console.ReadLine(), out int number))
        return number;
    else throw new ArgumentException("Вы ввели не число");
}

int [] FillArray(int [] array)
{
    Console.WriteLine("Массив:");
    for (int id = 0; id < array.Length; id++)
    {
        array[id] = new Random().Next(0, 100);
        Console.Write($" {array[id]}");
    }
    Console.WriteLine();
    return array;
}

void SummEvenNumbers(int [] array)
{
    int summ=0;
    for (int id = 1; id < array.Length; id+=2)
    {
        summ=summ+array[id];
    }
    Console.WriteLine($"Сумма элементов, расположенных на нечетных позициях в массиве [1, 3, 5...]: {summ}");
}

Console.WriteLine("Введите количество элементов в массиве:");
int [] array = new int[CheckNumber()];
SummEvenNumbers(FillArray(array));


