// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = GetArray(8, 0, 100);
Console.WriteLine(String.Join(" ", array));

int minNum = array[0];
int maxNum = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (maxNum < array[i])
    {
        maxNum = array[i];
    }
    if (minNum > array[i])
    {
        minNum = array[i];
    }
}
Console.WriteLine($"Значение максимального элемента: {maxNum}");
Console.WriteLine($"Значение минимального элемента: {minNum}");

Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {maxNum - minNum}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}