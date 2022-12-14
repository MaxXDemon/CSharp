int ChekingNumber() //Метод осуществляет проверку введенной в консоль строки на предмет числа
{
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        return number;
    }
    else throw new ArgumentException("Вы ввели не число");
}

int[,] CreateAndPrintArrayIntegers(int rows, int columns) //Метод создает и наполняет двухмерный массив целыми числами, а так же выводит его в консоль
{
    int [,] array = new int [rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

int [] TempArrayFirstString(int [,] array)//Метод записывает первую строчку в одномерный массив
{
    int [] arrFirst = new int [array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        arrFirst[j] = array[0,j];
    }
    Console.WriteLine();
    return arrFirst; 
}

int [] TempArrayLastString(int [,] array)//Метод записывает последнюю строчку в одномерный массив
{
    int [] arrLast = new int [array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        arrLast[j] = array[array.GetLength(0)-1,j];
    }
    return arrLast;
}

int [,] ReplacingFirstAndLastStrings(int [,] array, int [] arrFirst, int [] arrLast)//Метод меняет местами первую и последнюю строчку.
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [0,j] = arrLast [j];
        array [array.GetLength(0)-1,j] = arrFirst [j];
    }
    return array;
}

void PrintNewArray(int [,] array)//Метод выводит в консоль получившийся массив.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine($"Введите количество строк и столбцов соответственно:");
int [,] array = CreateAndPrintArrayIntegers(ChekingNumber(),ChekingNumber()); 
PrintNewArray(ReplacingFirstAndLastStrings(array,TempArrayFirstString(array),TempArrayLastString(array)));