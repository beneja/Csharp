// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

// int GetCol(int A)
// {
//     if (A != 0)
//     {
//         for (int i = 0; i <= A; i++) 
//         A = A/10;
//         }
//         return i;
// }
// Console.WriteLine("Введите число");
// int N  = int.Parse(Console.ReadLine()!);
int Count(int n)
{
    int i = 0;
    while (n != 0)
    {
        n = n/10;
        i = i + 1;
    }
    return i;
} 

Console.Clear();
int number = int.Parse(Console.ReadLine()!);
Console.Write(Count(number));
