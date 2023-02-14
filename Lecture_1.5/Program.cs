// Оператор if else
// .ToLower() - Позволяет выводить "Ура это же Маша", если мы водим слово Маша по познакому - мАША, МАШа, МАша



Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша") 
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

