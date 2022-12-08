Console.WriteLine("Введите размер массива:");
int number = 0;
PrintArray(ChekingNumber(Console.ReadLine()));

int ChekingNumber(string Number)
{
    if (int.TryParse(Number, out int number))
    {
        return number;
    }
    else throw new ArgumentException("Вы ввели не число");
}

void PrintArray (int number)
{
    int[]array = new int [number];
    for (int index = 0; index<number; index++)
    {
        array[index]= new Random().Next(0,10);
        Console.Write(" "+array[index]);
    }
    
}