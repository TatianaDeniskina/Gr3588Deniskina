using System;

int row = ReadData("Введите количество строк: ");
int colum = ReadData("Введите количество столбцов: ");
int[,]arr2D =Fill2DArray(row, colum, 10, 99);
Print2DArray(arr2D);
int[] avg = AvgCol(arr2D);
PrintData("Среднее арифметическое элементов в каждом столбце: ");
PrintDArr(avg);

void PrintData(string res)//метод вывода
 {
    Console.WriteLine(res);
 }
int ReadData(string msg)//метод ввода
{
   Console.WriteLine(msg);
   return int.Parse(Console.ReadLine() ?? "0");
}
int[,] Fill2DArray(int countRow, int countColum, int topBorder, int downBorder)//метод генерации 2мерного массива
{
    Random rand= new Random();
    int[,] arry2D = new int[countRow,countColum];
    for (int i =0; i< countRow; i++)
    {
        for(int j =0; j< countColum; j++)
        {
            arry2D[i,j]=rand.Next(topBorder, downBorder+1);
        }
    }
    return arry2D;
}
void Print2DArray(int[,] matrix)
{
    for (int i =0; i< matrix.GetLength(0); i++)
    {
        for(int j =0; j< matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+"    ".Substring(matrix[i,j].ToString().Length));
        }
        Console.WriteLine();
    }
}
void PrintDArr(int[] arr) //печать одномерного массива
 {
    for(int i=0; i < arr.Length -1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length -1]);
 }
int[] AvgCol(int[,] arr)//метод нахождения среденего арифметического
{
    int[] avg = new int [arr.GetLength(1)];
    for(int j=0; j<arr.GetLength(1); j++) 
    {
        for(int i=0;i<arr.GetLength(0);i++) 
        {
            avg[j]+=arr[i,j];
            //avg[j]= avg[i]/arr.GetLength(0);
        }
        
       avg[j]= avg[i]/arr.GetLength(0); //Имя "j" не существует в текущем контексте.
    }
 
return avg;
}