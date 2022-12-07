Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine());
int index = 1;
int Factorial(int number, int index)
{
    if (index==number)
    return index;
    return index*Factorial(number, index+1);    
}
Console.WriteLine(Factorial(number,index));