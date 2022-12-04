int number = new Random().Next(0,10000000);
Console.WriteLine(number);

if (number<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while ((number/10)>=100)
    {
        number=number/10;
    }
    Console.WriteLine(number%10);
    
}

