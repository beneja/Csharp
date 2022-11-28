// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int[,,] Get3DArray(int m, int n, int l, int[] array)
{
    int[,,] result = new int[m, n, l];
    int index = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                result[i, j, k] = array[index];
                index++;
            }
        }
    }
    return result;
}
int[] NonRepeatingRandom(int minValue, int maxValue, int size)
    {
        int[] randomArray = new int[size];
        for(int i = 0; i < size; i++)
        {
            randomArray[i] = new Random().Next(minValue, maxValue + 1);
            for(int j = 0; j < i; j++)
           {
               if(randomArray[i] == randomArray[j])
               {
                i--;
               }
           }
        } return randomArray;
    }

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int dim3 = int.Parse(Console.ReadLine()!);

int[] randomArray = NonRepeatingRandom(10, 99, rows*cols*dim3);
Console.WriteLine(String.Join(", ", randomArray));
int[,,] array = Get3DArray(rows, cols, dim3, randomArray);
PrintArray(array);

