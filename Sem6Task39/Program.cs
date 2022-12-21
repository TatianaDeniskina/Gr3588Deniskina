using System;
Console.WriteLine("Исходный массив: ");
int[] arr = Arr(20,1,100);
PrintDArr(arr);

int[] CopyArr=SwapNewArr(arr);
Console.WriteLine("Исходный массив перевернутый 1: ");
PrintDArr(CopyArr);
Console.WriteLine("Исходный массив: ");
PrintDArr(arr);

int[] CopyArrTwo = SwapArr(arr);
Console.WriteLine("Исходный массив перевернутый 2: ");
PrintDArr(CopyArrTwo);
Console.WriteLine("Исходный массив: ");
PrintDArr(arr);

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

 int[] SwapArr(int[] arr)
 {
    int bufElem=0;
    for(int i=0; i < arr.Length/2; i++)
    {
        bufElem=arr[arr.Length-1-i];
        arr[arr.Length-1-i]=arr[i];
        arr[i]=bufElem;
    }
    return arr;
 }
 int[] SwapNewArr(int[] arr)
 {
    int[] outArr = new int[arr.Length];
    for(int i=0; i < arr.Length; i++)
    {
        outArr[i] =arr[arr.Length-1-i];
    }
    return outArr;
 }
