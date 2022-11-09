// Задача 27: Напишите функцию и запустите ее, которая
// принимает на вход число и выдаёт сумму цифр в числе.
int SumOfDigits(int number)
{
    int result = 0;
    while(number != 0)
    {
        
        result += (number%10);
        number /= 10; 
        Console.WriteLine($"{number}, {result}");
    }
    return result;
}
Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumOfDigits(Number));