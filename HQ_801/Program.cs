/*Задача 54: Задайте двумерный массив. 
Напишите программу, 
которая упорядочит по убыванию элементы каждой 
строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/


/*Console.WriteLine($"Введите номер строки : ");
int.TryParse(Console.ReadLine(), out ni);
Console.WriteLine($"Введите номер столбца: ");
int.TryParse(Console.ReadLine(), out nj);
*/
Console.WriteLine();

//
int[,] array = new int[new Random().Next(2, 6), new Random().Next(3, 5)];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine();

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}
void sort(int[,] array, int index)
{
    int temp = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int ji = 1; ji < array.GetLength(1) - j; ji++)
        {
            if (array[index, ji] > array[index, ji - 1])
            {
                temp = array[index, ji];
                array[index, ji] = array[index, ji - 1];
                array[index, ji - 1] = temp;
            }
        }
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    sort(array, i);
}
Console.WriteLine($"Отсортированный массив :");
PrintArray(array);
