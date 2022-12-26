using System;

int row = ReadData("Введите количество строк: ");
int colum = ReadData("Введите количество столбцов: ");
int[,]arr2D =Fill2DIndexed(row, colum);
Print2DArray(arr2D);


int ReadData(string msg)//метод ввода
{
   Console.WriteLine(msg);
   return int.Parse(Console.ReadLine() ?? "0");
}
void Print2DArray(int[,]matrix)
{
    for (int i =0; i< matrix.GetLength(0); i++)
    {
        for(int j =0; j< matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int[,] Fill2DIndexed(int countRow, int countColum)//метод генерации 2мерного массива
{
    int[,] matrix = new int[countRow,countColum];
    for (int i =0; i< countRow; i++)
    {
        for(int j =0; j< countColum; j++)
        {
            matrix[i,j]=i+j;
        }
    }
    return matrix;
}
