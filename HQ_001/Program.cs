Console.WriteLine("Введите первое число: ");
string numberA = Console.ReadLine();
int numberAint = Convert.ToInt32(numberA);
Console.WriteLine("Введите второе число: ");
string numberB = Console.ReadLine();
int numberBint = Convert.ToInt32(numberB);

if(numberAint > numberBint)
{
    Console.WriteLine(numberAint);
}
else
{
    Console.WriteLine(numberBint);
}