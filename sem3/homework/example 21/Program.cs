// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double lineLenght(int[] A, int[] B)
{
    double result = Math.Round(Math.Sqrt(Math.Pow(A[0]-B[0],2) + Math.Pow(A[1]-B[1],2) + Math.Pow(A[2]-B[2],2)),2);
    return result;
}
int [] a = new int[3];
int [] b = new int[3];

Console.Write("Введите X для первой точки ");
a[0] = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y для первой точки ");
a[1] = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z для первой точки ");
a[2] = int.Parse(Console.ReadLine()!);

Console.Write("Введите X для второй точки ");
b[0] = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y для второй точки ");
b[1] = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z для второй точки ");
b[2] = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Расстояние между точками равна {lineLenght(a,b)}");