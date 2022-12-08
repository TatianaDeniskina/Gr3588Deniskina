using System;

int num = new Random().Next(100,1000);
int fznak = num/100;
int tznak = num%10;

int result = fznak*10+tznak;
Console.WriteLine(num);
Console.WriteLine(result);
