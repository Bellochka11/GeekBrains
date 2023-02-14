// Вход трехзначное число. Выход последняя цифра этого числа.
Console.WriteLine("Введите трехзначное число: ");
int  n = int.Parse(Console.ReadLine()!);
int a = n % 10;
Console.WriteLine($"Последняя цифра этого числа: {a}");

