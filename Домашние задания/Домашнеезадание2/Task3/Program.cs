//int day = new Random().Next(1,8);
//Console.WriteLine(day);
Console.WriteLine("Введите число от 1 до 7: ");
int day = int.Parse(Console.ReadLine());
switch (day)
{
    case 1: Console.WriteLine("Боже, Понедельник - опять на работу.");
    break;

    case 2: Console.WriteLine("Вторник - чеши на работу.");
    break;

    case 3: Console.WriteLine("Среда - опять на работу.");
    break;

    case 4: Console.WriteLine("Четверг - на работу, но скоро выходные.");
    break;

    case 5: Console.WriteLine("Пятница - почти выходной!");
    break;
    
    case 6: Console.WriteLine("Суббота - Ура, Выходной!!!");
    break;
    
    case 7: Console.WriteLine("Воскресенье - Ура, Выходной, но завтра опять на работу!");
    break;

    default: Console.WriteLine("В неделе семь дней!");
    break;
}