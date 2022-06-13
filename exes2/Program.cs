// Задача 2: Напишите программу, 
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
string numberA = Console.ReadLine();
int numberIntA = int.Parse(numberA);

Console.Write("Введите второе число: ");
string numberB = Console.ReadLine();
int numberIntB = int.Parse(numberB);

Console.Write("Введите второе число: ");
string numberC = Console.ReadLine();
int numberIntC = int.Parse(numberC);

int max = numberIntA;
    if (max < numberIntB)
    {
        max = numberIntB;
    }
    if (max < numberIntC)
    {
        max = numberIntC;
    }
Console.WriteLine("Максимальное число = {0}", max);