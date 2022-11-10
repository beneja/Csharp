﻿// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}

void GetChangeArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    };
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));
GetChangeArray(array);
Console.WriteLine(String.Join(" ", array));