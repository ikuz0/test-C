Console.WriteLine("Введите первое число: ");
int numberAint = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int numberBint = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int numberCint = int.Parse(Console.ReadLine()!);
if(numberAint>numberBint)
{
    if(numberAint>numberCint)
    {
    Console.WriteLine(numberAint);
    }
    else
    {
        Console.WriteLine(numberCint);
    }
}
else
{
    if(numberBint>numberCint)
    {
        Console.WriteLine(numberBint);
    }
    else
    {
        Console.WriteLine(numberCint);
    }
}
