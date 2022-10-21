/* Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел. */

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

if (a > b && a > c && a != b && a != c)
{
    Console.WriteLine($" Максимальное число равняется a = {a} = max");
}
else
{
    if (b > c && b != c)
    {
        Console.WriteLine($"Максимальное число равняется b = {b} = max");
    }
    else
    {
        Console.WriteLine($"Максимальное число равняется c = {c} = max ");
    }
}