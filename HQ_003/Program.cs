Console.WriteLine("Введите число: ");
string numberA = Console.ReadLine();
int numberAint = Convert.ToInt32(numberA);

if(numberAint%2 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}