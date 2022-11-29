// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
int SumDigits(int number)
{
    if (number == 0) { return 0; }
    int up = number / 10;
    int down = number % 10;
    return down + SumDigits(up);
}
Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int b = SumDigits(a);
Console.WriteLine(b);