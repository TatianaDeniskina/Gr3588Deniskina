using System;

int number = int.Parse(Console.ReadLine()); //вводим число
Console.WriteLine (number); //выводим число

if (number>99) // проверяем на наличие 3 цифры
{
    char[] digits = number.ToString().ToCharArray(); // заполняем массив цифрами введенного числа
    Console.WriteLine(digits[2]); // выводим 3 цифру
}
else
{
    Console.WriteLine ("Число не имеет третьей цифры"); // выводим если нет 3 цифры
}

