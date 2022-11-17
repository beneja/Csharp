// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 =
// 9 -> (-0,5; -0,5)
double[] IntersectionLine (double[] line1, double[] line2)
{
    double[] interseption = new double [2];
    if(line1[0] == line2[0] && line1[1] == line2[1])
    {
        Console.WriteLine("Это одна и та же прямая");
    }
    else
    {
        interseption[0] = (line1[1] - line2[1])/-(line1[0] - line2[0]);
        interseption[1] = (line2[0]*interseption[0]) +line2[1];
    }
    return interseption;
}
double[] GetArrayLine()
{
    double[] Line = new double [2];
    Console.Write("Введите коэффициент K прямой: ");
    double K = 0;
    K = double.Parse(Console.ReadLine()!);
    Line[0] = K;
    Console.Write("Введите коэффициент B прямой: ");
    double B = 0;
    B = double.Parse(Console.ReadLine()!);
    Line[1] = B;
    return Line;
}
Console.WriteLine("Ввод первой прямой");
double[] Line1 = GetArrayLine();
Console.WriteLine("Ввод второй прямой");
double[] Line2 = GetArrayLine();
double[] Interseption = IntersectionLine(Line1, Line2);
Console.WriteLine($"Точка пересечения прямых "+(String.Join(", ", Interseption)));