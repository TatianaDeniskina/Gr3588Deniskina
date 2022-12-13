using System;

int x1 = Cord("x", "A");
int y1 = Cord("y", "A");
int z1 = Cord("z", "A");
int x2 = Cord("x", "B");
int y2 = Cord("y", "B");
int z2 = Cord("z", "B");

int Cord(string corName, string pointName)
{
    Console.Write($"Введите координату {corName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Tochki(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Tochki(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Расстояние равно  {segmentLength}");