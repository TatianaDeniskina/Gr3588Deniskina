using System;

string number1 = Console.ReadLine();
string number2 = Console.ReadLine();
string number3 = Console.ReadLine();


int NUM1=int.Parse(number1);
int NUM2=int.Parse(number2);
int NUM3=int.Parse(number3);

if (NUM1>NUM2&&NUM2>NUM3)
{
    Console.WriteLine("Первое число больше второго и третьего " + NUM1+"> чем"+NUM2 +" и "+NUM3);
}
if (NUM2>NUM1&&NUM1>NUM3)
{
    Console.WriteLine("Второе число больше первого и третьего " + NUM2+"> чем"+NUM1 +" и "+NUM3);
}
else
    {
        Console.WriteLine("Третье число больше первого и второго " + NUM3+"> чем "+NUM1 +" и "+NUM2);
    }
