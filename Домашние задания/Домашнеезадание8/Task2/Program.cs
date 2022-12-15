/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой 
строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] CreateAndPrintArrayIntegers() //Метод создает и наполняет двухмерный массив целыми числами, а так же выводит его в консоль
{
    int rows = 4;
    int columns = 4;
    int[,] array = new int[rows, columns];
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

int[] GetSummStringArray(int[,] array)//Метод выдает сумму элементов строки массива.
{
    int summString = 0;
    int[] newArray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        summString = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summString += array[i, j];

        }
        Console.WriteLine(summString);
        newArray[i] = summString;

    }
    return newArray;
}

void PrintIndexStringMinSumm(int[] array)//Метод выводит в консоль номер строки с наименьшей суммой.
{
    int minSumm = array[0];
    int minSummIndex = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minSumm)
        {
            minSumm = array[i];
            minSummIndex = i + 1;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой значений №{minSummIndex}");
}

PrintIndexStringMinSumm(GetSummStringArray(CreateAndPrintArrayIntegers()));