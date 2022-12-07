Console.WriteLine("введите число: ");
string number = Console.ReadLine();


//int NumberOfDigits(string number)
//{
    char [] array = number.ToCharArray();
    int quantity = array.Length;
    //return (quantity);
//}
Console.WriteLine($"{quantity}");
