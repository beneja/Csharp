// Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.
int Tree(int H)
{
    for (int i = 1; i <= H; i++)
    {
        for (int j = 1; j <= H + i; j++)
        {
            if (j <= H - i + 1)
            {
                Console.Write(" ");
            }
            else Console.Write("*");
        }
        Console.Write("\n");
    }
    return H;
}
Console.Clear();
Console.WriteLine("Введите высоту ёлочки: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Tree(N);
Console.WriteLine();