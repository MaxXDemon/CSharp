Console.WriteLine("Введите число, которое хотели бы возвести в степень: ");
string input1 = Console.ReadLine();
Console.WriteLine("Введите степень, в которую хотели бы возвести число: ");
string input2 = Console.ReadLine();

if ((int.TryParse(input1, out int number))&&(int.TryParse(input2, out int degree)))
    {
       
              Console.WriteLine(Exponentiation(number, degree)); 
    }
else throw new ArgumentException("Вы ввели не число");

int Exponentiation(int number, int degree)
{
    int result = 1;
    for (int index = 0; index<degree; index++)
    {
        result=result*number;
    }
    return result;
}
