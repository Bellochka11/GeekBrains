﻿// Сложение двух чисел с помощью генератора псевдослучайных чисел

int numberA = new Random().Next(1,10); // случайное число от 1 до 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10); // случайное число от 1 до 9
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);