using System;

string Num1Line = Console.ReadLine();
string Num2Line = Console.ReadLine();

if(Num1Line!=null&&Num2Line!=null)
{
int num1=int.Parse(Num1Line);
int num2=int.Parse(Num2Line);
int outResult=num1*num2;
Console.WriteLine(outResult);
}

