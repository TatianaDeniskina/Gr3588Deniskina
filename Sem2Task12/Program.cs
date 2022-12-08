using System;

int number1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine (number1);
int number2 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine (number2);
int perem = number2%number1;
if (perem==0)
{
    Console.WriteLine ("является делителем");
}
else
{
    Console.WriteLine (" не является делителем остаток от деления "+perem);
}