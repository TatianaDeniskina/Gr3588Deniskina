using System;
int num = ReadData("Введите число");
PrintData(""+FibNum(num));
int ReadData(string msg)//метод ввода
{
   Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string res)//метод вывода
 {
    Console.WriteLine(res);
 }
 string FibNum(int num)
 {
    string outLine="0 1 ";
    int first = 0, last = 1, buf = 0;
    for(int i=2;i<num;i++)
    {
        outLine=outLine+" "+(first+last).ToString();
        buf=last;
        last=last+first;
        first=buf;
    }
    return outLine;
 }
