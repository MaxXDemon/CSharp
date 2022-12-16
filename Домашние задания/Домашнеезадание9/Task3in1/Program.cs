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

int AkkermanFunction(int mNumber, int nNumber)
{
    if (mNumber==0)
    {
        return nNumber+1; 
    }
    else if ((mNumber>0)&&(nNumber==0))
    {
        return AkkermanFunction(mNumber-1, 1);
    }
    else if ((mNumber>0)&&(nNumber>0))
    {
        return AkkermanFunction(mNumber-1, AkkermanFunction(mNumber,nNumber-1));
    }
    else return AkkermanFunction(mNumber,nNumber);
}

Console.WriteLine("Введите номер задания от 1 до 4:");
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

    case (4):
        Console.WriteLine(@"Задача 68: Напишите программу вычисления функции Аккермана
        с помощью рекурсии. Даны два неотрицательных числа m и n.
        m = 2, n = 3 -> A(m,n) = 9
        m = 3, n = 2 -> A(m,n) = 29");
        Console.WriteLine("Введите два числа m и n: ");
        Console.WriteLine(AkkermanFunction(CheckNumber(),CheckNumber()));
    break;
}

