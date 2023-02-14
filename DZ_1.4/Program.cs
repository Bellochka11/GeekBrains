// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine ("Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = 1;
while (num2 < num1)
{
    if (num2 % 2 == 0)
    {
        Console.WriteLine ($"{num2}");
    } 
    num2++;
}