Random rnd = new Random();
int firstNumber = rnd.Next(1,100);
Console.WriteLine(firstNumber);

int secondNumber = rnd.Next(1,100);
Console.WriteLine(secondNumber);

int resalt = secondNumber%firstNumber;
if (resalt==0)
{
    Console.WriteLine("Второе число кратное первому");
}
else
{
    Console.WriteLine($"Второе число не кратное первому. Остаток от деления={resalt}");
}