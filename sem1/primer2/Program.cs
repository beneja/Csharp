﻿// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine()!);
if (num == 1)
    Console.WriteLine("Это понедельник!");
else if (num == 2)
     Console.WriteLine("Это вторник!");
else if (num == 3)
     Console.WriteLine("Это среда!");
else if (num == 4)
     Console.WriteLine("Это четверг!");
else if (num == 5)
     Console.WriteLine("Это пятница!");
else if (num == 6)
     Console.WriteLine("Это субботу!");
else if (num == 7)
     Console.WriteLine("Это воскресенье!");
else 
Console.Write("Попробуйте еще раз! ");

