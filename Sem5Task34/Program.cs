using System;
int[] array = Arr(123,100,999);
PrintDArr(array);

int res = CountEven(array);
PrintData("Количество четных чисел в массиве: ", res);
void PrintData(string res, int value)//метод вывода
 {
    Console.WriteLine(res+value);
 }
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
int CountEven(int[]arr)
{
    int res =0;
     for (int i=0; i < arr.Length; i++)
    {
        if(arr[i]%2==0)
        res++;
    }
    return res;
    
}