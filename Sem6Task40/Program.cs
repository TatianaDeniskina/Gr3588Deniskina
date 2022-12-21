using System;
int a = ReadData("Введите первое число ");
int b = ReadData("Введите второе число ");
int c = ReadData("Введите третье число ");

if(TriangleTest(a,b,c)) {PrintData("Треугольник существует ");}
else {PrintData("Треугольник не существует ");}

int ReadData(string msg)//метод ввода
{
   Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string res)//метод вывода
 {
    Console.WriteLine(res);
 }
 bool TriangleTest(int a,int b, int c)
 {
    return((a+b>c)&&(a+c>b)&&(b+c>a));
 }
