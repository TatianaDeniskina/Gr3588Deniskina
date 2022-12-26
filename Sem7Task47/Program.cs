using System;

int row = ReadData("Введите количество строк: ");
int colum = ReadData("Введите количество столбцов: ");
double[,]arr2D =Fill2DArray(row, colum);
Print2DArray(arr2D);


int ReadData(string msg)//метод ввода
{
   Console.WriteLine(msg);
   return int.Parse(Console.ReadLine() ?? "0");
}
double[,] Fill2DArray(int countRow, int countColum)//метод генерации 2мерного массива
{
    Random rand= new Random();
    double[,] arry2D = new double[countRow,countColum];
    for (int i =0; i< countRow; i++)
    {
        for(int j =0; j< countColum; j++)
        {
            arry2D[i,j]=rand.NextDouble();
        }
    }
    return arry2D;
}
void Print2DArray(double[,] matrix)
{
    for (int i =0; i< matrix.GetLength(0); i++)
    {
        for(int j =0; j< matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+"  ,  ");
        }
        Console.WriteLine();
    }
}



