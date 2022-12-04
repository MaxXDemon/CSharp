

Console.WriteLine("Введите первое число:");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int secondNumber = int.Parse(Console.ReadLine());

if ((firstNumber/secondNumber==secondNumber) || (secondNumber/firstNumber==firstNumber))
{
    Console.WriteLine("Одно число является квадратом другого");
}    
else 
{
    Console.WriteLine("Первое число не является квдратом второго, а второе не является квдратом первого");
}
 


