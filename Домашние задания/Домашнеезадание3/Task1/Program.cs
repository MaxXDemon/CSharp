Console.WriteLine("Введите число:");
string number = Console.ReadLine();

char [] array = number.ToCharArray();
Array.Reverse(array);
string number2= new String(array);
if (number==number2)
{
    Console.WriteLine("Это число является полиндромом");    
}
else
{
    Console.WriteLine("Это число НЕ является полиндромом");
}

// int length = array.Length(array);
// Console.WriteLine(array[2]);
// int [] array = new int [5];
// double result = 1;
// int index = 0;
// int count = 10000;
// if ((number%count!=0) && (number/count!=0))
// while (count>0)
// {
//     array[index] = number/count;
//     number=number-(number*count);
//     count=count/10;
//     index++;
// }

// Console.WriteLine(array[2]);