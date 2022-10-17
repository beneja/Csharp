/* Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.*/
Console.Clear();

int num = new Random().Next(100, 1000);
int third = num / 100;
int second = num % 10;
int result = third * 10 + second;

Console.Write($"{num}, {result}");