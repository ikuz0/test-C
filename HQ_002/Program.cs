Console.WriteLine("Введите первое число: ");
string numberA = Console.ReadLine();
int numberAint = Convert.ToInt32(numberA);
Console.WriteLine("Введите второе число: ");
string numberB = Console.ReadLine();
int numberBint = Convert.ToInt32(numberB);
Console.WriteLine("Введите третье число: ");
string numberC = Console.ReadLine();
int numberCint = Convert.ToInt32(numberC);
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
