using System;

int num = ReadData("Введите длину массива:  ");//вволим длину массива
int line1 = ReadData("Введите первое число диапазона:  ");//вводим диапазон выбора
int line2 = ReadData("Введите второе число диапазона:  ");//рандомных чисел
int [] arr = Arr(num);
PrintData("Сгенерированный массив: ",arr); // вывод массива

int ReadData(string msg)//метод ввода
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

 void PrintData(string res, int[] arr)//метод вывода
 {
    Console.WriteLine(res);
    PrintArr(arr);
 }
 int[] Arr(int num)//метод заполнения массива рандомными числами
 {
    int[] arr = new int [num];
    Random random = new Random();
    for (int i = 0; i<arr.Length;i++)
    {
        arr[i]=random.Next(line1,line2);
    }
    return arr;
 }
 void PrintArr(int[] arr)//метод вывода массива
 {
    Console.Write("[");
    for (int i = 0; i<num-1;i++)
    {
       Console.Write(arr[num-1]+",");

    }  
    Console.WriteLine(arr[num-1]+"]");
}   