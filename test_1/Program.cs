/*
Задача 2: Напишите программу, которая на вход принимает два числа 
и выдаёт, какое число большее, а какое меньшее.
*/

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

bool isNotNumberAEqualB = a != b;

if (isNotNumberAEqualB)
{

    if (a > b && isNotNumberAEqualB)
    {
        Console.WriteLine($"Число a = {a} = max");
    }
    else
    {
        Console.WriteLine($"Число b = {b} = max");
    }
}
else
{
    Console.WriteLine($"Число a = {a} равняется числу b = {b}");
}