// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите первое число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);
    if (numberInt%2==0)
    {
        Console.WriteLine("Число является четным  ");
    }
    else
    {
        Console.WriteLine("Число является не четным ");
    }