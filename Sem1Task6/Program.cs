using System;

string Num = Console.ReadLine();

int num=int.Parse(Num);

int Result = num%2;
if (Result==0)
{
    Console.WriteLine("Число "+num+" четное");
}
else
{
    Console.WriteLine("Число "+num+" нечетное");
}

