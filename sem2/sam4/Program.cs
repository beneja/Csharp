/* Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.*/
Console.Clear();

int num = new Random().Next(100, 1000);
int second = num / 100;
int third = num % 10;
int result = second * 10 + third;

Console.Write($"{num}, {result}");