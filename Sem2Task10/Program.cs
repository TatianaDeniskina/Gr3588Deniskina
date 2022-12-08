using System;

int num = new Random().Next(100,1000); // генерируем рандомное число
int tznak = num/10; //убираем третий знак, получаем двузначное число
int sznak = tznak%10; //убираем первую цифру двузначного числа
Console.WriteLine("Число:"+num); //выводим сгенерируемое число
Console.WriteLine("Вторая цифра: "+sznak); //выводим результат
