// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y)

string GetQuater(int number)
{
    string answer = "";
    if (number == 1)
    {
        answer = "x > 0 & y > 0";
    }
    else if (number == 2)
    {
        answer = "x > 0 & y < 0";
    }
    else if (number == 3)
    {
        answer = "x < 0 & y < 0";
    }
    else if (number == 4)
    {
        answer = "x > 0 & y < 0";
    }

    return answer;
}

Console.Clear();
int X = int.Parse(Console.ReadLine()!);
string text = GetQuater(X);
Console.WriteLine(text);
