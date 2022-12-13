using System;

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Stepen(int[] cube)
{
  int counter = 0;
  int length = cube.Length;
  while (counter <  length)
  {
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintData(int[] res)
{
  int count = res.Length;
  int index = 0;
  while(index < count)
  {
    Console.Write(res[index]+ " ");
    index++;
  }
} 

int[] znachenie = new int[cube+1];
Stepen(znachenie);
PrintData(znachenie);



