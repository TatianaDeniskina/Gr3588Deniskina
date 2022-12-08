using System;

Random numberSintezator = new Random();

int number = numberSintezator.Next(10,100);
Console.WriteLine(number);

int fnumber = number/10;
int snumber = number%10;
if (fnumber>snumber)
{
    Console.WriteLine(fnumber);
}
else
{
    Console.WriteLine(snumber);
}

