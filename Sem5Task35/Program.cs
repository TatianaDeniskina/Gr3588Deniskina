using System;
int[] array = Arr(123,-100,100);
PrintDArr(array);

int res = CountElem(array,10,99);
PrintData("Количество элементов массива, значение которых лежит в отрезке [10,99] составляет ", res);


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
    Console.WriteLine(arr[arr.Length -1 ]);
 }
 void PrintData(string res, int value)//метод вывода
 {
    Console.WriteLine(res+value);
 }
 int CountElem (int[] arr, int min, int max)

 {
    int res=0;
    for (int i=0; i < arr.Length -1; i++)
    {
        if (arr[i]>min&&arr[i]<max)
        {
            res++;
        }
        
        
    }
    return res;
 }
