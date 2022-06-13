// Задача 4: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите первое число: ");
string number = Console.ReadLine();
int numberIntN = int.Parse(number);
int index = 1;
while (index <= numberIntN )
{
   if (index%2==0)
   {
        Console.WriteLine(index);
   }
   index++;
}
Console.WriteLine("End");