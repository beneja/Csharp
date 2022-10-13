//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// Задача 1: введем 2 числа на проверку числа квадратом другого
 Console.Write("Введите первое число: ");
 int number1 = int.Parse(Console.ReadLine()!);
 Console.Write("Введите второе число: ");
 int number2 = int.Parse(Console.ReadLine()!);
 if ((number2*number2) == number1)
    Console.WriteLine($"Квадрат числа {number2} равен {number1}, значит ДА!");
else
    Console.WriteLine($"Квадрат числа {number2} неравен {number1}, значит НЕТ!");
