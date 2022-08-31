int number = new Random().Next(1, 8);
Console.WriteLine("Введите номер дня недели: ");


if (number < 6)
{
    Console.WriteLine($"{number} -> Нет");
}
else
{
    Console.WriteLine($"{number} -> Да");
}