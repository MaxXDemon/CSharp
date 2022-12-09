int ChekingNumber()
{
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        return number;
    }
    else throw new ArgumentException("Вы ввели не число");
}

int [] FillingArray(int [] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
}

int [] NumberRevers(params int [] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<0)
        {
            array[i] = array[i]*-1;
        }
        else array[i] = array[i]-array[i]*2; 
    }
    return array;
}

void SearchNumber(int [] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) 
        {
            Console.WriteLine($"Число {number} находится на {i+1} позиции");
            count++;
        }
    }
    if (count==0) Console.WriteLine($"Число {number} в массиве нет");
}

Console.WriteLine("Задайте количество элементов массива:");
int [] array = new int[ChekingNumber()];
FillingArray(array);
PrintArray(array);
NumberRevers(array);
PrintArray(array);
Console.WriteLine("Введите число для поиска:");
int number = ChekingNumber();
SearchNumber(array, number);