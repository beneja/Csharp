/* Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
.*/
 Console.Write("Введите число: ");
 int number1 = int.Parse(Console.ReadLine()!);
 
 if (number1 % 7 == 0 && number1 % 23 == 0)
 {
    Console.WriteLine("Число кратно 7 и 23");
 }
else
    Console.WriteLine("не кратно  7 и 23");