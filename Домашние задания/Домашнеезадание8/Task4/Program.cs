/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int ChekingNumber() //Метод осуществляет проверку введенной в консоль строки на предмет числа
{
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        return number;
    }
    else throw new ArgumentException("Вы ввели не число");
}

int[,,] CreateArray(int x, int y, int z)//Метод заполняет массив уникальными двухзначными числами (если это возможно!!!). 
{
    if (x * y * z < 100) //Проверка на возможность заполнения массива УНИКАЛЬНЫМИ числами
    {
        int[,,] array = new int[x, y, z];
        Dictionary<int, int> repeatingNumber = new Dictionary<int, int>();
        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = new Random().Next(10, 100);
                    if (repeatingNumber.ContainsKey(array[i, j, k]))
                    {
                        k--;
                    }
                    else
                        repeatingNumber.Add(array[i, j, k], 1);
                }
            }
        }
        return array;
    }
    else throw new ArgumentException("Невозможно заполнить уникальными двухзначными числами массив такого размера");
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($" {array[i, j, k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"Введите размер трехмерного массива (Строка, Столбец, Глубина):");
PrintArray(CreateArray(ChekingNumber(), ChekingNumber(), ChekingNumber()));