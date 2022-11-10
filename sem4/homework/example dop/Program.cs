// Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.
void FirTree(int haight)
{
    string line = "";
    string star = "*";
    int countProbel = haight - 1;
    int countStar = 1;
    //Console.WriteLine(countProbel);
    for (; haight != 0; haight--)
    {
        while (countProbel != 0)
        {
            line += " ";
            countProbel--;
        }
        Console.WriteLine($"{line}{star}");
        while (countStar < haight)
        {
            star += "**";
            countProbel--;
        }
        
        line.Remove(0, 2);
        star += "**";
               
    }

}
Console.Write("Введите высоту ёлочки: ");
int Haight = int.Parse(Console.ReadLine()!);
FirTree(Haight);
