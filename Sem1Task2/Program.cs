using System;

string number1 = Console.ReadLine();
string number2 = Console.ReadLine();

int NUM1=int.Parse(number1);
int NUM2=int.Parse(number2);

if (NUM1>NUM2)
{
    Console.WriteLine("Первое число больше второго" +NUM1+">"+NUM2);
}
if (NUM1==NUM2)
{
    Console.WriteLine("Числа равны" +NUM1+"="+NUM2);
}
else
    {
        Console.WriteLine("Второе число больше первого" +NUM2+">"+NUM1);
    }
