// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.

double lineLenght(int[] A, int[] B)
{
    double result =Math.Round(Math.Sqrt(Math.Pow(A[0]-B[0],2) + Math.Pow(A[1]-B[1],2)),2);
    return result;
}
int [] a = new int[2];
int [] b = new int[2];

Console.Write("Введите X для первой точки ");
a[0] = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y для первой точки ");
a[1] = int.Parse(Console.ReadLine()!);

Console.Write("Введите X для второй точки ");
b[0] = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y для второй точки ");
b[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Расстояние между точками равна {lineLenght(a,b)}");
