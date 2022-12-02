// Это первая задача во втором задании
// Console.WriteLine("Введите первое число:");
// int number1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int number2 = int.Parse(Console.ReadLine());
// if (number1/number2 == number2)
// {
//     Console.WriteLine("Да");
// } else
// Console.WriteLine("Нет");


//Это вторая задача
//Console.WriteLine("Введите число от 1 до 7:");
int day = int.Parse(Console.ReadLine());

switch(day)
{
    case 1: 
    Console.WriteLine("Понедельник");
        break;
    case 2: 
    Console.WriteLine("Вторник");
        break;
    case 3: 
    Console.WriteLine("Среда");
        break;
    case 4: 
    Console.WriteLine("Четверг");
        break;
    case 5: 
    Console.WriteLine("Пятница");
        break;
    case 6: 
    Console.WriteLine("Суббота");
        break;
    case 7: 
    Console.WriteLine("Воскресенье");
        break;
    default: 
    Console.WriteLine("Некорректное число");
    break;
}