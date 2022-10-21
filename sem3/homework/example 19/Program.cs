// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
bool Palindrom(int X)
{
    int a = (X - X % 10000) / 10000;
    int b = X % 10;
    int c = ((X%10000) - (X%1000)) / 1000;
    int d = ((X%100) - b)/10;
    if(c == d && a == b)
    {
    return true;
    }
    else return false;
    
}

Console.WriteLine("Введите пятизначное число: ");
int numb = int.Parse(Console.ReadLine()!);
if (numb > 9999 && numb < 100000)
{
    bool Numb = Palindrom(numb);
    if(Numb == true)
    {
        Console.WriteLine("Число палиндром");
    }
    else Console.WriteLine("Число не палиндром");
}
