Console.WriteLine("Введите номер четверти:");
int number = int.Parse(Console.ReadLine());


switch (number)
    {
    case 1:
        Console.WriteLine($"Координаты 'x' в диапазоне от 0 до бесконечности и 'y' в диапазоне от 0 до бесконечности");
        break;
    case 2:
        Console.WriteLine("Координаты 'x' в диапазоне от минус бесконечности до 0 и 'y' в диапазоне от 0 до бесконечности");
        break;
    case 3:
        Console.WriteLine("Координаты 'x' в диапазоне от минус бесконечности до 0 и 'y' в диапазоне от минус бесконечности до 0");
        break;
    case 4:
        Console.WriteLine("Координаты 'x' в диапазоне от 0 до бесконечности и 'y' в диапазоне от минус бесконечности до 0");
        break;
    default:
        break;
    }