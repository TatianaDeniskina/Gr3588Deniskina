using System;

int[] array = Arr(10,-9,9);
PrintDArr(array);
int[] newArr = InversArr(array);
PrintDArr(newArr);

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

int[] InversArr(int[] arr)
{
    int[] outArr=new int[arr.Length];
    for(int i=0; i < arr.Length; i++)
    {
        outArr[i]=arr[i]*(-1);
    }
    return outArr;
}