// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

using System;
class MyProgram
{
    static void getPows(int N){
        for (int i=1;i<=N;i++) Console.Write((i*i).ToString()+((i!=N)?", ":""));
    }
 
    static void Main()
    {
        Console.Write("Введите N:");
        int n = int.Parse(Console.ReadLine());
        
        getPows(n);
    }
}
