// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
Console.WriteLine("Ведите первое число");
int numb1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ведите второе число");
int numb2 = int.Parse(Console.ReadLine()!);

if (numb1 * numb1 == numb2 || numb2 * numb2 == numb1)
  {
  Console.WriteLine("да");
  }
else 
{
    Console.WriteLine("нет");
}