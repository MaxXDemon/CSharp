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
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" "+array[i]);
    }
    Console.WriteLine();
}

void SearchEvenNumber(params int [] array)
{
    int count = 0;
    foreach (int number in array)
    {
        if (number%2==0)
            {
            count++;
            }
    }
    Console.WriteLine($"В заданном массиве нечетных чисел: {count}");
   
}

Console.WriteLine("Задайте количество элементов массива:");

int [] array = new int[ChekingNumber()];
PrintArray(FillingArray(array));
SearchEvenNumber(FillingArray(array));