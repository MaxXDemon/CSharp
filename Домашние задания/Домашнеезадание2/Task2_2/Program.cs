//Поиск третьей цифры справа
int number = new Random().Next(0,10000000);
Console.WriteLine(number);

// int result = (number-((number/1000)*1000))/100;
//     Console.WriteLine($" Третья цифра справа {result}");

//Поиск третей цифры слева

if (number<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int result = (number-((number/1000)*1000))/100;
    Console.WriteLine($"Третья цифра справа {result}");

    while ((number/10)>=100)
    {
        number=number/10;
    }
    Console.WriteLine($"Третья цифра слева {number%10}");
    
}













