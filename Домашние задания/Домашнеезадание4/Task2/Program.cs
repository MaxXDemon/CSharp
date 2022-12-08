Console.WriteLine("Введите любое число:");
string Number = Console.ReadLine();
int length = Number.Length;
Summ(ChekingNumber(Number),length);

int ChekingNumber(string Number)
{
    if (int.TryParse(Number, out int number))
    {
        return number;
    }
    else throw new ArgumentException("Вы ввели не число");
}

void Summ (int number, int length)
{
    int summ=0;
    for (int index = 0; (index<length); index++)
    {
        summ=summ+number%10;
        number=number/10;
    }
    Console.WriteLine(summ);
}