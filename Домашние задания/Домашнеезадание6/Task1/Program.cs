// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountNumbers()
{
    int count = 0;
    while (int.TryParse(Console.ReadLine(), out int number) == true)
    {
        if (number > 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Для выхода введите любой символ, кроме числа:");
Console.WriteLine("Для подсчета введите любое число:");
Console.WriteLine(CountNumbers());