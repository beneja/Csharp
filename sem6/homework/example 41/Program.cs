// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
int[] FillFromKeyboardArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Введите числа: ");
    for(int i = 0; i < size; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}
int CountPositiv(int[] array)
{
    int count = 0;
    foreach(int i in array)
    {
        if(i > 0)
        {
            count++;
        }
    }
    return count;
}
int num = 0;
Console.WriteLine("Сколько чисел вы хотите ввести?");
num = int.Parse(Console.ReadLine()!);
int[] Array = FillFromKeyboardArray(num);
Console.WriteLine($"Вы ввели {CountPositiv(Array)} положительных");


