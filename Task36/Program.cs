// /Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] array = GetArray(6, -10, 30);
int result = Sum(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, в массиве [{String.Join(", ", array)}] равна {result}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] intArray = new int[size];

    for (int i = 0; i < intArray.Length; i++)
    {
        int number = new Random().Next(minValue, maxValue + 1);
        intArray[i] = number;
    }
    return intArray;
}

int Sum(int[] list)
{
    int sum = 0;
    for (int i = 1; i < list.Length; i += 2)
    {
        sum += list[i];
    }
    return sum;
}