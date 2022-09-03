// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число В: ");
// int B = Convert.ToInt32(Console.ReadLine());

// Console.Write("Степень = " +(Math.Pow(A, B)));



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = 0;

// void SumDigits()
// {
//     while(number > 0)
//     {
//         result = result + number % 10;
//         number = number / 10;
//     }

//     Console.Write("Сумма цифр: " +result);
// }

// SumDigits();



// Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран. Пользователь вводит число элементов в массиве и минимальное, и максимальное значение. Надо заполнить массив рандоными данными от минимального до максимального значение. И важное уточнениее, делать все в методе который возвращает массив.

Console.Write("Введите число элементов в массиве: ");
int elements = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elements];

void PrintArray(int[] array)
{
    for(int index = 0; index < elements; index ++)
    {
        array[index] = new Random().Next(min, max + 1);
        Console.Write(array[index] +" ");
    }
}

PrintArray(array);
