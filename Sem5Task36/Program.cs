using System;
int[] array = Arr(100,0,999);//генерируем одномерный массив
PrintDArr(array);//выводим сгенерированный массив

int res = SumOdd(array);//суммируем элементы на нечетных позициях
PrintData("Сумма элементов, стоящих на нечетных позициях ", res);//выводим результат

int[] Arr(int len, int minValue, int maxValue)//метод заполнения массива рандoмными числами
 {
    int[] arr = new int [len];
    Random random = new Random();
    for (int i = 0; i<arr.Length;i++)
    {
        arr[i]= new Random().Next(minValue,maxValue+1);
    }
    return arr;
 }
 void PrintDArr(int[] arr) //печать одномерного массива
 {
    for(int i=0; i < arr.Length -1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length -1]);
 }
 void PrintData(string res, int value)//метод вывода
 {
    Console.WriteLine(res+value);
 }
 int SumOdd(int[]arr)// метод суммирования элементов стоящих на нечетных позициях
 {
    res=0;
    int i=1;
    while (i<arr.Length)
    {
        res=res+=arr[i];
        i=i+2;
    }
    return res;
 }