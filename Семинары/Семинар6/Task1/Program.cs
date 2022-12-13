
int CheckNumber()
{
    
    if (int.TryParse(Console.ReadLine(), out int number)) return number;
    else throw new ArgumentException("Это не число, попоробуйте снова");
}

void CreateAndPrintArray(int m, int n)
{
    int [,] array = new int [m,n];
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(-9, 10);
            Console.Write($" {array[i,j]}");  
        }
    Console.WriteLine();
    }
}

Console.WriteLine("Введите размер двумерного массива");
CreateAndPrintArray(CheckNumber(),CheckNumber());

