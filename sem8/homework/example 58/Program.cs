// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}
Console.Clear();
Console.WriteLine("Первая матрица");
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] array1 = GetArray(rows, cols, 0, 10);
Console.WriteLine("Втора матрица");
Console.Write("Введите кол-во строк: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int cols2 = int.Parse(Console.ReadLine()!);
int[,] array2 = GetArray(rows2, cols2, 0, 10);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
if (array1.GetLength(1) == array2.GetLength(0))
{
    int[,] resultMatrix = MultiplyMatrices(array1, array2);
    PrintArray(resultMatrix);
}
else Console.WriteLine("Матрицы нельзя перемножить");