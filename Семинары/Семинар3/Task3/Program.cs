Console.WriteLine("Введите число:");

int n = int.Parse(Console.ReadLine());
int square =-1;

for (int index = 1; index<n; index++)
{
    //square=Math.Pow(index,2);
    Console.Write($"{Math.Pow(index,2)}  ");
} 
