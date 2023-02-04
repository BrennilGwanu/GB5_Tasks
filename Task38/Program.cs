// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] array = GetArray(6, 20);
double result = Difference(Max(array), Min(array));
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {result:f5} "); 


double[] GetArray(int size, int maxValue)
{
    double[] dArray = new double[size];

    for (int i = 0; i < dArray.Length; i++)
    {
        double number = new Random().NextDouble()*maxValue;
        dArray[i] = number;
    }
    return dArray;
}

double Max(double[] list)
{
    double max_imp = list[0];
    for (int i = 1; i < list.Length; i++)
    {
        if (list[i] > max_imp)
            max_imp = list[i];
    }
    return max_imp;
}

double Min(double[] list)
{
    double min_imp = list[0];
    for (int i = 1; i < list.Length; i++)
    {
        if (list[i] < min_imp)
            min_imp = list[i];
    }
    return min_imp;
}

double Difference(double num1, double num2)
{
    double dif = num1 - num2;
    return dif;
}