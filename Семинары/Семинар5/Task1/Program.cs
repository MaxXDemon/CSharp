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
        Console.Write(" "+array[i]);
    }
    Console.WriteLine();
}

void SummPlusMinus(params int [] array)
{
    int summPlus=0;
    int summMinus=0;
    foreach (int number in array)
    {
        if (number<0)
        {
            summMinus+=number;
        }
        else summPlus+=number; 
    }
    Console.WriteLine($"Сумма отрицательных чисел = {summMinus}");
    Console.WriteLine($"Сумма положительных чисел = {summPlus}");
}

Console.WriteLine("Задайте количество элементов массива:");
//int number = ChekingNumber();
int [] array = new int[ChekingNumber()];
FillingArray(array);
PrintArray(array);
SummPlusMinus(array);

