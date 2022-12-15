/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int ChekingNumber() //Метод осуществляет проверку введенной в консоль строки на предмет числа
{
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        return number;
    }
    else throw new ArgumentException("Вы ввели не число");
}

int[,] CreateAndPrintArray(int rows, int columns) //Метод создает двухмерный массив и выводит его в консоль.
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

int [,] FillArray(int [,] array) //Метод заполняет массив по спирали 
{
    int numbers = array.GetLength(0)*array.GetLength(1);
    int step = 1;
    int row = 0;
    int columns = 0;
    
    while (step <= numbers)
    {
        array[row,columns] = step;
        step++;

        if (row <= columns+1 && row + columns < array.GetLength(1)-1)
        {
            columns++;
        }
        else if (row < columns && row + columns >= array.GetLength(0)-1)
        {
            row++;
        }
        else if (row >= columns && row + columns > array.GetLength(1)-1)
        {
            columns--;
        }
        else 
            row--;
    }
    return array;
}

void PrintArray(int [,] array) //Метод выводит в консоль получившийся массив, подставляя ноль перед одноразрядными числами
{
    for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int columns = 0; columns < array.GetLength(1); columns++)
            {
                if (array[row,columns]/10==0)
                    Console.Write($"0{array[row, columns]} ");
                else Console.Write($"{array[row, columns]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
}


Console.WriteLine($"Введите количество строк и столбцов массива:");
int [,] array = CreateAndPrintArray(ChekingNumber(),ChekingNumber());
PrintArray(FillArray(array));




