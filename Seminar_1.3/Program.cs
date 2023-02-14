// На вход число N а на выходе целые числа от -N до N
Console.WriteLine("Введите число: ");
int  n = int.Parse(Console.ReadLine()!);
 int count = -n;
while (count <= n)
{
    Console.Write($"{count} ");
    count++;
}

