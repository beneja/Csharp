// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным элементов
// массива
// [3 7 22 2 78] -> 76
double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble()*20;
        res[i] = Math.Round(res[i], 2);
    }
    return res;
}

double[] array = GetArray(10);
Console.WriteLine(String.Join(", ", array));
double Diff(double[] array)
{
    double Min = array[0];
    double Max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        
        if(array[i] < Min)
        {
            Min = array[i];
        }
        if(array[i] > Max)
        {
            Max = array[i];
        }
        
    }
    double Dif = Max - Min;
    return Dif;
}
Console.WriteLine($"{Diff(array)}");