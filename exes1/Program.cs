// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
string numberA = Console.ReadLine();
int numberIntA = int.Parse(numberA);

Console.Write("Введите второе число: ");
string numberB = Console.ReadLine();
int numberIntB = int.Parse(numberB);

    if (numberIntA > numberIntB) 
    {
        Console.Write("Первое число больше = ");
        Console.WriteLine(numberA);
    }
    else
    {
        Console.Write("Второе число больше = ");
        Console.WriteLine(numberB);
    }