using System;
int day = int.Parse(Console.ReadLine());//Вводим число дня недели 
if ((day<8)&&(day>0))//проверяем на корректность
{
    if (day<6) // если от 1-5 то выводим "рабочий"
    {
        Console.WriteLine ("Рабочий день");
    }
    else // если от 6,7 то выводим "выходной"
    {
         Console.WriteLine ("Выходной день");
    }
}
else
{
    Console.WriteLine ("Дня недели не существует"); // выводим если нет дня недели
}