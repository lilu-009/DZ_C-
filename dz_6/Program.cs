// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Write("Введите несколько чисел через пробел: ");
// string numbers = Console.ReadLine();

// string[] array = numbers.Split(" ");

// int count = 0;

// for(int i = 0; i < array.Length; i++)
// {
//     if(Convert.ToInt32(array[i]) > 0) count ++;
// }

// Console.Write(count +" чисел больше 0");



// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите коэффициент k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэффициент k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2)
{
    Console.Write($"Прямые y = {k1} * x + {b1} и y = {k2} * x + {b2} не пересекаются (параллельные)");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.Write($"Точка пересечения прямых y = {k1} * x + {b1} и y = {k2} * x + {b2} - ({x}, {y})");
} 
