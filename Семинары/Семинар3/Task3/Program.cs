Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());

for (int index = 1; index<n; index++)
{
    Console.Write($"{Math.Pow(index,2)}  ");
} 
