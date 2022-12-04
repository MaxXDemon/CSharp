int number = new Random().Next(100,1000);
Console.WriteLine(number);
int resalt = (number-(number/100)*100);
resalt=resalt/10;
Console.WriteLine(resalt);
