// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int beginCount = 2;
while(beginCount <= number)
{
    Console.Write($"{beginCount} ");
    beginCount += 2;
}
for (int i = 2; i <= number; i +=2)
{
    Console.Write($"{i} ");
}