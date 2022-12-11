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
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
}

void SearchNumber(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>=10 && array[i]<=99) 
        {
            count++;
        }
    }
    Console.WriteLine($"Количество элементов на отрезке от 10 до 99 = {count}");
}

int [] ProductNumber(int [] array)
{
    int length = 0;
    int i = 0;
    int j = array.Length-1;
    int count = 0;
    if (array.Length%2==0) 
    {
        length = array.Length/2;
        int [] arr = new int [length];
        while (i!<j)
        {
            arr[i]=array[i]*array[j];
            i++;
            j--;
            count++;
        }
        return arr;
    }
    else 
    {
        length = array.Length/2+1;
        int [] arr = new int [length];
        while (i!<j)
        {
            arr[i]=array[i]*array[j];
            i++;
            j--;
            count++;
        }
        arr[count]= array[count];
        return arr;
    }
        
        //int [] arr = new int [length];

    // while (i!<j)
    // {
    //     arr[i]=array[i]*array[j];
    //     i++;
    //     j--;
    //     count++;
    // }
 
    //arr[count]= array[count];
    //return arr;
}

Console.WriteLine("Задайте количество элементов массива:");
int [] array = new int[ChekingNumber()];
FillingArray(array);
PrintArray(array);
SearchNumber(array);
PrintArray(ProductNumber(array));