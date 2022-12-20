using System;
int[] array = Arr(123,-100,100);
PrintDArr(array);

int[] res = ConvertArr(array);
PrintDArr(res);

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
 int[] ConvertArr(int[]arr)
 {
    int[] outArr = new int[arr.Length/2];
    for(int i=0; i<arr.Length/2; i++)
    {
        outArr[i]=arr[i]*arr[arr.Length-1-i];
    }
    return outArr;
 }
