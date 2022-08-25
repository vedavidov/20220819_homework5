// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = GetArray(8, 1, 10);
Console.WriteLine(String.Join(" ", array));

int sum = 0;

for (int i = 1; i < array.Length; i = i + 2)
    sum = sum + array[i];

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях (i=1,3,5,7): {sum}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}