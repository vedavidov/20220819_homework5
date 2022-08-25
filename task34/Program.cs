// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = GetArray(8, 100, 1000);
Console.WriteLine(String.Join(" ", array));

int count = 0;

foreach (int el in array)
{
    if (el % 2 == 0)
        count = count + 1;
}
Console.WriteLine($"Количество чётных чисел в массиве: {count}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}