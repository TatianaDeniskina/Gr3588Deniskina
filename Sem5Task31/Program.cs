using System;

int posetivSum=0;
int negativSum=0;

int[] testArr=Arr(12,-9,9);
NegotivPositivSum(testArr);
PrintData("Сумма положительных чисел в массиве: ",posetivSum);
PrintData("Сумма отрицательных чисел в массиве: ",negativSum);

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
 void PrintData(string res, int value)//метод вывода
 {
    Console.WriteLine(res+value);
 }
 void NegotivPositivSum(int[] arr)
 {
    for (int i=0; i<arr.Length;i++)
    {   
        if(arr[i]>0)
     {
         posetivSum += arr[i];
     }
     else
     {
        negativSum += arr[i];
     }
       
    }
 }
 