using System;
int num = ReadData("Введите число ");

PrintData("Результат: "+ DecToBin(num));

int ReadData(string msg)//метод ввода
{
   Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string res)//метод вывода
 {
    Console.WriteLine(res);
 }
 string DecToBin(int num)
 {
    string outBin=String.Empty;
    while (num>0)
    {
        outBin=(num%2)+outBin;
        num=num/2;
    }
    return outBin;
 }
