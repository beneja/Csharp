// Задача 50. Напишите программу, которая на вход принимает число и ищет его в двумерном массиве.
// Программа должна возвращать значение позиции (номер строки и столбца)
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}
string FindNumber(int[,] array, int number)
{
    string Match = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(number == array[i, j])
            {
                Match += i;
                Match += ",";
                Match += j;
                Match += " ";
            }
        }
    }
    return Match;
   
}
void Answer(string result)
{
    if(result == string.Empty)
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else Console.WriteLine(result);
}
Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
int [,] Array = GetArray(rows, cols, 0, 10);
PrintArray(Array);
Console.WriteLine("Позицию какого числа вы хотите найти? ");
int number = int.Parse(Console.ReadLine()!);
string match = (FindNumber(Array, number));
Answer(match);

