// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

// Например;
// 4 -> 16
// -3 -> 9
// -7 -> 49


Console.WriteLine("Введите число:");
// string answer = Console.ReadLine(); // "123"
// int number = Convert.ToInt32(answer); // "123" -> 123

int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number * number);
