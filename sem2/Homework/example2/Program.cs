//Напишите программу, которая выводит третью цифру (справа налево)
//заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите трёхзначное число: ");
int numb = int.Parse(Console.ReadLine()!);
if (numb > 99)
{
    while (numb > 999)
    {
        numb = (numb - (numb%10))/10;
        Console.WriteLine(numb);
    }
    int third = numb - numb%100;
    Console.WriteLine($"третья спраца цифра {third/100}");
}
else Console.WriteLine("Третьей цифры нет");