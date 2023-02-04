// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] array = GetArray(8, 100, 999);
int result = EvenNum(array);
Console.WriteLine($"Количество чётных чисел в массиве [{String.Join(", ", array)}] --> {result}");


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

int EvenNum(int[] list)
{
    int qty = 0;
    foreach (int el in list)
    {
        if (el % 2 == 0)
            qty++;
    }
    return qty;
}