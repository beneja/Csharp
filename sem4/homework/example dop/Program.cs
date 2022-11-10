// Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.
void FirTree(int haight)
{
    string line = "";
    string star = "*";
    int countProbel = haight - 1;
    int 
    for (; haight != 0; haight--)
    {
        while (line.Length < haight)
        {
            line += " ";
        }
        Console.WriteLine($"{line}{star}");
        line.Remove(0, 2);
        star += "**";
               
    }

}
Console.Write("Введите высоту ёлочки: ");
int Haight = int.Parse(Console.ReadLine()!);
FirTree(Haight);
