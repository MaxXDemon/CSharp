Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int i = 1;
while (i<number)
{
    if (i%2==0) 
    {
        Console.WriteLine(i);
        i++;
    }
    else
    {
        i++;
    }
}