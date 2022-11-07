// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// int GetMult(int value)
// {
//     int i = 1;
//     while (i <= value)
//     {
//         i *= i;
//         i++;
//     }

// }
// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);

// int mult = GetMult(N);

int Product(int n)
{
    int prod = 1;
    for (int i = 1; i <= n; i = i + 1)
    {
        prod = prod*i;
    }
    return prod;
} 

Console.Clear();
int number = int.Parse(Console.ReadLine()!);
Console.Write(Product(number));
