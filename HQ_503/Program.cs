/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

void FillArray(double[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().NextDouble() * 100;
        index++;
    }
}
void PrintArray(double[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]:F2} ");
    }
    Console.WriteLine();
}
void diff(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        if (max < array[i])
        {
            max = array[i];
        }
    }
    Console.WriteLine($"Min>> {min:F2}||| Max>> {max:F2}");
    Console.WriteLine($"Разница>>> {max - min:F2}");
}


double[] array = new double[10];
FillArray(array);
PrintArray(array);
diff(array);

