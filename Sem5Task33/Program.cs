using System;
int[]array=Arr(10,-9,10);
PrintDArr(array);
int num = ReadData("Введите число: ");
int res = SearchElem(array, num);
if (res>=0)
{
    PrintData("Элемент найден в позиции: "+ res);
}
else
{
    PrintData("Элемент не найден ");
}
int ReadData(string msg)//метод ввода
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
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
    Console.WriteLine(arr[arr.Length -1 ]);
 }
 void PrintData(string res)//метод вывода
 {
    Console.WriteLine(res);
 }
  int SearchElem(int[] arr, int elem)
  {
    int res = -1;
    for(int i=0; i < arr.Length; i++)
    {
        if(arr[i]==elem);
        {
            res=i;
            break;
        }
        
        
    }
    return res;
  }