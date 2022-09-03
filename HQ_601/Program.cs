/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

*/


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент: >> ");
        array[i] = int.Parse(Console.ReadLine()!);

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

void Counnt(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Колличество элементов больше 0 >>>> {count}");
}

Console.WriteLine("Введите колличество элементов: ");
int num = int.Parse(Console.ReadLine()!);
int[] array = new int[num];
FillArray(array);
PrintArray(array);
Counnt(array);