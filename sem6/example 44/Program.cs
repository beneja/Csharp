// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
int[] Feb(int A)
{
    int[] array = new int[A];
    if (A > 1)
    {
        array[0] = 0;
    }
    if (A > 2)
    {
        array[1] = 1;
    }
    for (int i = 2; i < A; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
    }
    return array;
}
Console.WriteLine("Введите количество чисел в последовательности Фебоначи: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(String.Join(", ", Feb(N)));