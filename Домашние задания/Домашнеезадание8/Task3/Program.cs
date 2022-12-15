/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
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

void CheckingPossibilityMatrixMultiplication(int columnFirstMatrix, int rowSecondMatrix)//Метод проверяет матрицы на возможность их умножения.
{
    if (columnFirstMatrix != rowSecondMatrix)
        throw new ArgumentException("Умножение таких матриц невозможно");
}

void PrintResultMatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)//Метод умножает матрицы и выводит результат в консоль.
{
    int result = 0;
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            result = 0;
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                result += firstMatrix[i, k] * secondMatrix[k, j];
            }
            Console.Write($" {result}");
            //array[i, j] = result;
            //Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"Введите количество строк и столбцов первой матрицы:");

int rowFirstMatrix = ChekingNumber();
int columnFirstMatrix = ChekingNumber();

Console.WriteLine($"Введите количество строк и столбцов второй матрицы:");
int rowSecondMatrix = ChekingNumber();
int columnSecondMatrix = ChekingNumber();

CheckingPossibilityMatrixMultiplication(columnFirstMatrix, rowSecondMatrix);

int[,] firstMatrix = CreateAndPrintArrayIntegers(rowFirstMatrix, columnFirstMatrix);
int[,] secondMatrix = CreateAndPrintArrayIntegers(rowSecondMatrix, columnSecondMatrix);

PrintResultMatrixMultiplication(firstMatrix, secondMatrix);




