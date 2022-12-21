using System;
int x=0;
int y=0;
int k1 = ReadData("Введите первый коэффициент: ");//
int k2 = ReadData("Введите второй коэффициент: ");//
int b1 = ReadData("Введите b1: ");//                      вводим данные для решения системы уравнений
int b2 = ReadData("Введите b2: ");//

PointInter(k1,k2,b1,b2);//находим точку пересечения
Console.WriteLine("Точка пересечения: ("+x+";"+y+")");//выводим результат

int ReadData(string msg)//метод ввода
{
   Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
 int PointInter(int k1, int k2, int b1, int b2)//метод нахождения точки пересечения
 {  
    {
        x=((b2-b1)/(k1-k2));
        y=k2*((b2-b1)/(k1-k2))+b2;
    }
   
    return x;
    return y;
 }
