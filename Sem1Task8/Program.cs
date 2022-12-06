using System;

string Num = Console.ReadLine();

int num=int.Parse(Num);
int Delitel = 2;
string res = string.Empty;
while (Delitel<num)
{
   res=res+Delitel+",";
   Delitel=Delitel+2; 
}
Console.WriteLine(res);
