// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка
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
int[] SmallestSumRowsArray(int[,] array)
{
    int index = 0;
    int[] sumArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
        sum += array[i, j];
        }
        sumArray[index++] = sum;
        sum = 0;
    }
    return sumArray;

}
void GetMinIndex(int[]sumArray)
{   int Min = sumArray[0];
    int indexMin = 0;
    for(int i = 1; i < sumArray.Length; i++)
    {
        if(Min > sumArray[i])
        {
            Min = sumArray[i];
            indexMin = i;
        }
    }
    Console.WriteLine($"В {indexMin + 1} строке сумма элементов наименьшая");
}
Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
Console.WriteLine();

int[] sum = SmallestSumRowsArray(array);
// Console.WriteLine(String.Join(", ", sum));
GetMinIndex(sum);
