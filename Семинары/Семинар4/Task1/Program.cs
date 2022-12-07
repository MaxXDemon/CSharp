Console.WriteLine("введите число: ");
string number = Console.ReadLine();
Console.WriteLine(NumberOfDigits(number));

int NumberOfDigits (string number)
{
    if (int.TryParse(number, out int i))
    {
    char [] array = number.ToCharArray();
    int quantity = array.Length;
    return quantity;
    }
    throw new ArgumentException("Вы ввели не число");
}

