Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine());
if (number>99 && number<1000)
{
    Console.WriteLine (number%10);
}