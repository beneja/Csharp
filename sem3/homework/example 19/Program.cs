// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
bool Palindrom(int X)
{
    //поиск разрядов
    int a5 = (X - X % 10000) / 10000;
    int a1 = X % 10;
    int a4 = ((X%10000) - (X%1000)) / 1000;
    int a2 = ((X%100) - a1)/10;
    if(a4 == a2 && a5 == a1)
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
