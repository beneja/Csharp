// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumInterval(int number1, int number2)
{
    
    if (number2 == number1) return number2;
    return number2 + SumInterval(number1,number2 - 1);
    
}
Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumInterval(number1, number2));