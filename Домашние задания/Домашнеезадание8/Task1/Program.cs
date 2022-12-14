/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

int [] GetString(int [,] array, int numberRow)//Метод записывает строку из двухмерного массива в одномерный.
{
    int [] row = new int [array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        
        row[i] = array[numberRow,i];
           
    }
    return row;
}

int [] SortingNumbersInDescendingOrder(int [] array)//Метод сортирует элементы в массиве по убыванию
{   
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length-i-1; j++)
        {
            if (array[j] < array[j+1])
            {
                int temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
            }
            
        }
    }
    return array;
}

void PrintRow(int [] array)//Метод выводит в консоль i-ую строку массива
{
    for (int i = 0; i < array.Length; i++)
    Console.Write($" {array[i]}");
}

void PrintArray(int [,] array)//Метод выводит в консоль итоговый массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        PrintRow(SortingNumbersInDescendingOrder(GetString(array,i)));
        Console.WriteLine();
    }
}

Console.WriteLine($"Введите количество строк и столбцов соответственно:");
int [,] array = CreateAndPrintArrayIntegers(ChekingNumber(),ChekingNumber());
PrintArray(array);