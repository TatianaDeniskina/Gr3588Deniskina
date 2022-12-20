using System;
int[] array = Arr(123,100,999);//генерируем одномерный массив
PrintDArr(array);//выводим сгенерированный массив

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
int CountEven(int[]arr)//метод суммирования элементов 
{
    int res =0;
     for (int i=0; i < arr.Length; i++)
    {
        if(arr[i]%2==0)
        res++;
    }
    return res;
    
}