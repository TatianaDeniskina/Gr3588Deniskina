using System;

int row = ReadData("Введите количество строк: ");
int colum = ReadData("Введите количество столбцов: ");
int[,]arr2D =Fill2DArray(row, colum, 10, 99);
Print2DArray(arr2D);
int x = ReadData("Введите номер элемента по y: ");
int y = ReadData("Введите номер элемента по x: ");
int elem = SearchElem(arr2D,x,y);
PrintData("Элемент: "+elem);



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
int SearchElem(int[,] arr, int x, int y)
{
    int elem = -1;
    if (x<arr.GetLength(0))
    {
        if(y<arr.GetLength(1))
        {
            elem=arr[x,y];
        }
    }

    return elem;
}
