using System;

int m = ReadData("Введите число строк 1-й матрицы: ");//вводим количество сторок
int n = ReadData("Введите число столбцов 1-й матрицы (и строк 2-й): ");//вводим количество солбцов и строк
int p = ReadData("Введите число столбцов 2-й матрицы: ");//вводим количество солбцов 
int range = ReadData("Введите диапазон случайных чисел: от 1 до ");//вводим ограничение на предельное значение генерации


int[,] firstMartrix = Fill2DArray(m,n,1,range);//генерируем первую матрицу

Console.WriteLine($"\nПервая матрица:");
Print2DArray(firstMartrix);//выводим первую матрицу

int[,] secomdMartrix = Fill2DArray(n,p,1,range);//генерируем вторую матрицу

Console.WriteLine($"\nВторая матрица:");
Print2DArray(secomdMartrix);//выводим вторую матрицу

int[,] resultMatrix = new int[m,p];//создаем результирующую матрицу

MultiplayMatrix(firstMartrix, secomdMartrix, resultMatrix);//считаем произведение матриц
Console.WriteLine($"\nПроизведение первой и второй матриц:");
Print2DArray(resultMatrix);//выводим результат

void MultiplayMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)//метод умножения матриц 
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
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

void Print2DArray(int[,] matrix)//метод вывода двумерного массива
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