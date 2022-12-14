using System;

int num = ReadData("Введите число: //вводим число
int pow = ReadData("Введите степень: ");//вводим степень
int res = Pow(num,pow);//считаем значение

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

int Pow(int num, int pow)//метод возведения в степень
{
    int res =1;
    for (int i = 1;i<=pow;i++)
    {
        res=num*res;
    }
    return res;

}
