// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine()!);
if (num * num / num > 99 && num * num / num < 1000)
{
    int second = (num % 100 - num % 10) / 10;
    Console.WriteLine($"Вторая цифра {second}");

}
