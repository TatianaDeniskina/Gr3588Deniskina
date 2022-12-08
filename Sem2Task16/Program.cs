using System;

int number1 = int.Parse(Console.ReadLine()??"0");
int number2 = int.Parse(Console.ReadLine()??"0");
bool rez1 = (number1/number2==number2);
bool rez2 = (number2/number1==number1);

if (rez1)Console.WriteLine ("перый квадрат второго");
if (rez2)Console.WriteLine ("второй квадрат первого");
if (!rez1||rez2!)Console.WriteLine ("не являются квадратами");

