// Задача 29: Напишите программу, которая задаёт массив из 8
// элементов и выводит их на экран. Массив заполняется с клавиатуры
int[] FillArray()
{
int [] nums = new int[8];
for (int i = 0; i < nums.Length; i++)
    {
        Console.Write("введите число: ");
        nums[i] = int.Parse(Console.ReadLine()!);
    }
    return nums;
}
int[] NewArray = FillArray();
Console.Write(String.Join(",", NewArray));