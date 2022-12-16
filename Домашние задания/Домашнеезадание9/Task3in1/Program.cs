int CheckNumber()
{
    if (int.TryParse(Console.ReadLine(), out int number))
        return number;
    else throw new ArgumentException("Это не число, попробуйте снова");
}

void CheckingCondition(int firstNumber, int lastNumber)
{
    if (firstNumber >= lastNumber)
        Console.WriteLine("Введенные значения не соответствуют условию поставленной задачи.");
}

void PrintNumbers(int firstNumber)
{
    if (firstNumber >= 1)
    {
        Console.Write($"{firstNumber} ");
        PrintNumbers(firstNumber - 1);
    }
}

void SummNumbers(int firstNumber, int lastNumber)
{
    if (firstNumber < lastNumber)
        SummNumbers(firstNumber++, lastNumber);
    else
        Console.WriteLine(firstNumber);
}

Console.WriteLine("Введите номер задания от 1 до 3:");
switch (CheckNumber())
{
    case (1):
        Console.WriteLine(@"Задача 1: Задайте значение N. 
        Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
        Выполнить с помощью рекурсии.");
        Console.WriteLine("Введите любое число: ");
        int firstNumber = CheckNumber();
        PrintNumbers(firstNumber);
        break;

    case (2):
        Console.WriteLine(@"Задача 2: Задайте значения M и N. Напишите программу, 
        которая найдёт сумму натуральных элементов в промежутке от M до N.");
        Console.WriteLine("Введите два числа (первое должно быть меньше второго): ");
        int firstNumber = CheckNumber();
        int lastNumber = CheckNumber();
        CheckNumber(firstNumber, lastNumber);
        SummNumbers(firstNumber, lastNumber);

}

