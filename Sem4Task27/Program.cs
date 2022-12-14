using System;
int num = ReadData("Введите число: ");//вводим число
int res = SumDigit(num);//считаем сумму цифр
PrintData(res);//выводим результат

int ReadData(string msg)//метод ввода
{
   Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

 void PrintData(int res)//метод вывода
 {
    Console.WriteLine(res);
   
 }
int SumDigit(int num)//метод сложения цифр числа
{
    int res=0;
    while (num>0)
    {
        res+=num%10;
        num=num/10;
    }
    return res;
}