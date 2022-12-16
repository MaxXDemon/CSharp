int CheckNumber()
{
    if (int.TryParse(Console.ReadLine(), out int number))
        return number;
    else throw new ArgumentException("Это не число, попробуйте снова");
}

void CheckingCondition(int firstNumber, int lastNumber)
{
    if (firstNumber > lastNumber)
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

void PrintNumbersTwo(int firstNumber, int lastNumber)
{
    if (firstNumber <= lastNumber)
    {
        Console.Write($"{firstNumber} ");
        PrintNumbersTwo(firstNumber + 1, lastNumber);
    }
}

int SummNumbers(int firstNumber, int lastNumber)
{
    if (firstNumber<=lastNumber)
        {
            return firstNumber+SummNumbers(firstNumber+1,lastNumber);
        }
    else return 0;
       
}

Console.WriteLine("Введите номер задания от 1 до 3:");
switch (CheckNumber())
{
    case (1):
        Console.WriteLine(@"Задача 1: Задайте значение N. 
        Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
        Выполнить с помощью рекурсии.");
        Console.WriteLine("Введите любое число: ");
        PrintNumbers(CheckNumber());
        break;
    
    case (2):
        Console.WriteLine(@"Задача 1-1: Задайте значения M и N. 
        Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
        Выполнить с помощью рекурсии.");
        Console.WriteLine("Введите любое число: ");
        int firstNum = CheckNumber();
        int lastNum = CheckNumber();
        CheckingCondition(firstNum,lastNum);
        PrintNumbersTwo(firstNum,lastNum);
        break;

    case (3):
        Console.WriteLine(@"Задача 2: Задайте значения M и N. Напишите программу, 
        которая найдёт сумму натуральных элементов в промежутке от M до N.");
        
        Console.WriteLine("Введите два числа (первое должно быть меньше второго): ");
        
        int firstNumber = CheckNumber();
        int lastNumber = CheckNumber();
        CheckingCondition(firstNumber,lastNumber);
        Console.WriteLine(SummNumbers(firstNumber,lastNumber));
    break;

    

}

