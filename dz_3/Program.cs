// Задача 19

Console.Write("Введите пятизначное число: ");
string number = Convert.ToString(Console.ReadLine());
char[] array = number.ToCharArray();

if(array[0] == array[4] && array[1] == array[3])
{
    Console.Write("Это палиндром");
}
else
{
    Console.Write("Это не палиндром");
}



// Задача 21

// Console.WriteLine("Введите координаты первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// int z2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Расстояние = {Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2))}");



// Задача 23

// Console.Write("Введите число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// for(int number2 = 1; number2 <= number1; ++ number2)
// {
//     Console.Write(Math.Pow(number2, 3) +",");
// }
