// Принимает на вход число и выдает его квадрат ( число умножить на само себя)
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
// Решение математически 
int number = num * num;
Console.WriteLine($"Квадрат {num} равен: {number}");

// Решение с помощью библиотеки
int num2 = Convert.ToInt32(Math.Pow(num, 2)); //Конвертируем с типа double в int. Math.Pow - возведение в степень
Console.WriteLine($"Квадрат {num} равен: {num2}");