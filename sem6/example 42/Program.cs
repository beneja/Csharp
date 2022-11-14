// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
int GetBinariNumber(int number)
{
    String result = "";
    if (number == 0) return 0;
    while (number > 0)
    {
        result = (number % 2).ToString() + result;
        number /= 2;
    }
    return int.Parse(result);
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(GetBinariNumber(num));
