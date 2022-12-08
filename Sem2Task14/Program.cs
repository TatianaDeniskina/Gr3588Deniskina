using System;

int number = int.Parse(Console.ReadLine()??"0");
Console.WriteLine (number);
int rez1 = number%7;
int rez2 = number%23;
Console.WriteLine (rez1);
Console.WriteLine (rez2);
if ((rez1==0)&&(rez2==0))
{
    Console.WriteLine ("yes");
}
else
{
    Console.WriteLine (" no");
}
