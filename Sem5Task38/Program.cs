using System;
double min=double.MaxValue;//задаем минимальное значение
double max=double.MinValue;//задаем максимальное значение
double[] array = Arr(6,0,10);//генерируем одномерный массив
PrintDArr(array);//выводим сгенерированный массив
double res=max-min;//находим разницу между максимальным элементом и минимальным
PrintData("Разница между максимальным и минимальным элементом массива ", res);//вывод результата


void PrintData(string res, double value)//метод вывода
 {
    Console.WriteLine(res+value);
 }
double[] Arr(int len, int minValue, int maxValue)//метод заполнения массива рандoмными числами
 {
    double[] arr = new double [len];
    Random random = new Random();
    for (int i = 0; i<arr.Length;i++)
    {
        arr[i]= new Random().Next(minValue,maxValue+1);
    }
    return arr;
 }
 void PrintDArr(double[] arr) //печать одномерного массива
 {
    for(int i=0; i < arr.Length -1; i++)
    {
        Console.Write(arr[i] + ";");
    }
    Console.WriteLine(arr[arr.Length -1]);
 }

void MinMax(double[] arr)//метод нахождения максимального и минимального элемента
{
    for(int i=0; i < arr.Length; i++)
    {
        if (arr[i]>max) 
        max=arr[i];
        if (arr[i]<min) 
        min=arr[i];
    }
}