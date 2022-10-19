//Напишите программу, которая выводит третью цифру (справа налево)
//заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите трёхзначное число: ");
int numb = int.Parse(Console.ReadLine()!);
if (numb > 99)
{
    numb = numb%1000;    
    numb = (numb - numb%100)/100;
    Console.WriteLine($"Третья слева цифра {numb}");
}
else Console.WriteLine("Третьей цифры нет");