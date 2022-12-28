using System;

int m = ReadData("Введите m: ");//вводим количество солбцов
int n = ReadData("Введите n: ");//вводим количесество сторок
int range = ReadData("Введите диапазон: от 1 до ");//вводим ограничение на предельное значение генерации
 

int[,] arr= Fill2DArray(m,n,1,range);//генерируем массив
Print2DArray(arr);//печатаем массив

Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(arr);//расставляем элементы по убыванию
Print2DArray(arr);//печатаем получившийся массив

void OrderArrayLines(int[,] array)//метод сортировки массива по убыванию
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
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