// Первая задача
// Console.WriteLine("Введите число:");
// int a = int.Parse(Console.ReadLine());
// int b = (a-a*2);
// Console.Write(b);
// while (b<a)
// {
//     b=b+1;
//     Console.Write($"{b} ");
// }

int number = int.Parse(Console.ReadLine());
if (number>99 && number<1000)
{
    Console.WriteLine (number%10);
}