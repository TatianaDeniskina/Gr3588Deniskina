using System;

int num = ReadData("Введите число: ");
int pow = ReadData("Введите степень: ");
int res = Pow(num,pow);

PrintData(res);

int ReadData(string msg)
{
   Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

 void PrintData(int res)
 {
    Console.WriteLine(res);
   
 }

int Pow(int num, int pow)
{
    int res =1;
    for (int i = 1;i<=pow;i++)
    {
        res=num*res;
    }
    return res;

}
