// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите два числа: ");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
if (num1 > num2)
{
    Console.Write($"Максимальное число: {num1}, а минимальное {num2}" );
}
else
{
    Console.Write($"Максимальное число: {num2}, а минимальное {num1}" );
}
