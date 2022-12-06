using System;

string lineA = Console.ReadLine();
string [] dayWeek = new string[7];
dayWeek[0]= "понедельник";
dayWeek[1]= "вторник";
dayWeek[2]= "среда";
dayWeek[3]= "четверг";
dayWeek[4]= "пятница";
dayWeek[5]= "суббота";
dayWeek[6]= "воскресенье";
int A = int.Parse(lineA);
Console.WriteLine(dayWeek[A-1]);

