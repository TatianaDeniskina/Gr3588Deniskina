using System;
int N = ReadData("Введите количество чисел: ");//вводим количество чисел
PrintData("Результат: "+CountPosNum(N));//выводим результат
int ReadData(string msg)//метод ввода
{
   Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string res)//метод вывода
 {
    Console.WriteLine(res);
 }
 int CountPosNum(int N)//метод подсчета положительных чисел
 {
    int res = 0;
    while(N>0)
    {
       if(ReadData("Введите число: ")>0) res++;

        N=N-1;
    }
    return res;
 }
