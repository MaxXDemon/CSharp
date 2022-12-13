/* Напишите программу, которая найдёт точку пересечения двух прямых,
   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
   значения b1, k1, b2 и k2 задаются пользователем.
   b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
/*
    Для определения точки пересечения двух прямых, 
заданных системой уровнений, требуется преобразовать 
данные уровнения следующим образом:
k1 * x + b1 =  k2 * x + b2 ->
k1 * x - k2 * x = b2 - b1 -> 
x*(k1 - k2) = b2 - b1 ->
x = (b2 - b1) / (k1 - k2) тогда
y = k2 * ((b2 - b1) / (k1 - k2)) + b2 
*/
double CheckNumber()
{
    if (double.TryParse(Console.ReadLine(), out double number))
    {
        return number;
    }
    else throw new ArgumentException("Это не число, попробуйте снова:");
}

void IntersectionPoint(double b1, double k1, double b2, double k2)
{

    if ((k1 - k2 == 0) && (b1 - b2 == 0))
    {
        Console.WriteLine($"Данные прямые совпадают и имеют бесконечное число пересечений");
    }
    else if ((k1 - k2 == 0))
    {
        Console.WriteLine($"Данные прямые параллельны и не имеют точек пересечения");
    }
    else
    {
        double x = 0;
        double y = 0;
        x = (b2 - b1) / (k1 - k2);
        y = k2 * ((b2 - b1) / (k1 - k2)) + b2;
        Console.WriteLine($"Точка пересечения прямых находится в координатах ({x};{y}");
    }
}
Console.WriteLine("Введите b1, k1, b2 и k2 соответственно:");
IntersectionPoint(CheckNumber(), CheckNumber(), CheckNumber(), CheckNumber());
