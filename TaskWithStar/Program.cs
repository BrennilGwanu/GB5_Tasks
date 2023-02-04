// Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сортировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

Console.Clear();
int[] array = GetArray(5, -10, 10);
Console.WriteLine($"[{String.Join(", ", array)}]");
int[] sort = Booble(array);
Console.WriteLine($"[{String.Join(", ", sort)}]");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] intArray = new int [size];

        for (int i = 0; i < intArray.Length; i++)
        {
            int number = new Random().Next(minValue, maxValue + 1);
            intArray[i] = number;
        }
        return intArray;
}

int[] Booble(int[] list)
{
    int[] new_list = list;
    int min = -10;
    for (int i1 = 0; i1 < list.Length; i1++)
    {
        for (int i2 = i1+1; i2 < list.Length; i2++)
        {
            if (new_list[i1] < new_list[i2])
            {
                min = new_list[i1];
                new_list[i1] = new_list[i2];
                new_list[i2] = min;
            }
        }
    }
    return new_list;
}


