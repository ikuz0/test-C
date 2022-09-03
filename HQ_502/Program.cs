/*Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-100, 100);
        index++;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void СountingEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i % 2) != 0)
        {
            count = count + array[i];
            //Console.WriteLine($"подсчет>>{count}");
        }
    }
    Console.WriteLine($"Колличество четных элементов массива >> {count}");
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);
СountingEven(array);
