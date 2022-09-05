/*Задача 43: Напишите программу, 
которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine("Введите значения для первого уравнения: B1,K1: ");
Console.WriteLine("В1: ");
double B1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("K1: ");
double K1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значения для второго уравнения: B2,K2: ");
Console.WriteLine("В2: ");
double B2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("K2: ");
double K2 = double.Parse(Console.ReadLine()!);
double x;
double y;
Console.WriteLine($"Уравнение 1-й прямой Y={K1}*X+{B1} ");
Console.WriteLine($"Уравнение 2-й прямой Y={K2}*X+{B2} ");

if (K1 == K2)
{
    if (B1 == B2)
    {
        Console.WriteLine($"Прямые накладываются");
    }
    else
    {
        Console.WriteLine($"Прямые параллельны");
    }
}
else
{
    x = (B2 - B1) / (K1 - K2);
    y = x * K1 + B1;
    Console.WriteLine($"координата точки >> ({x};{y})");
}



