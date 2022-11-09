// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Exponentiation(int number, int degree)
{
    int Result = number;
    for (int count = 1; count < degree; count++)
    {
        Result *= number;
    }
    return Result;
}
Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int Degree = int.Parse(Console.ReadLine()!);

Console.WriteLine(Exponentiation(Number, Degree));