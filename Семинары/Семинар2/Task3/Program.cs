Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

if ((number%7 == 0) && (number%23 == 0)) 
{
    Console.WriteLine($"Число {number} делится без остатка и на 7 и на 23");
}
else 
{
    Console.WriteLine($"Число {number} НЕ делится без остатка и на 7 и на 23");
}
