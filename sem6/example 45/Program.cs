// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования. 
int[] CopyArray(int[] array)
{
    int[] newarray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newarray[i] = array[i];
    }
    return newarray;
}

int[] GetArray(int dim, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[dim];
    for (int count = 0; count < dim; count++) { array[count] = rnd.Next(min, max + 1); }
    return array;
}

String ArrayToString(int[] array)
{
    return "[" + String.Join(", ", array) + "]";
}

int[] massiv = GetArray(8, 0, 10);
Console.WriteLine(ArrayToString(massiv));
int[] copyOfmassiv = CopyArray(massiv);
Console.WriteLine(ArrayToString(copyOfmassiv));
