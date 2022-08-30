Console.WriteLine("Введите первое число: ");
int numberAint = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int numberBint = int.Parse(Console.ReadLine()!);

if(numberAint > numberBint)
{
    Console.WriteLine(numberAint);
}
else
{
    Console.WriteLine(numberBint);
}