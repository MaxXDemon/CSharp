int CheckNumber()
{
    if (int.TryParse(Console.ReadLine(), out int number))
        return number;
    else throw new ArgumentException("Это не число, попробуйте снова");
}

void PrintNumbers(int firstNumber)
{
    if (firstNumber >= 1)
    {
        Console.Write($"{firstNumber} ");
        PrintNumbers(firstNumber-1);
    }
    
}

Console.WriteLine("Введите номер задания от 1 до 3:");
switch(CheckNumber())
{
    case (1): 
        Console.WriteLine(@"Задача 1: Задайте значение N. 
        Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
        Выполнить с помощью рекурсии.");
        Console.WriteLine("Введите любое число: ");
        int firstNumber = CheckNumber();
        PrintNumbers(firstNumber);
    break;

}

