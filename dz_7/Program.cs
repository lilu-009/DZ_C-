// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble();
            Console.Write(Math.Round(array[i, j], 1) + " ");
        }
        Console.WriteLine();
    }
}

double[,] array = new double[4, 5];
PrintArray(array);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] array = new int[3, 4];
// PrintArray(array);

// Console.Write("Введите номер строки: ");
// int i = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите номер столбца: ");
// int j = Convert.ToInt32(Console.ReadLine());

// if(i <= array.GetLength(0) && j <= array.GetLength(1))
// {
//     Console.Write($"Элемент {i} строки и {j} столбца - {array[i - 1, j - 1]}");
// }
// else
// {
//     Console.Write("Такого элемента нет");
// }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] array = new int[3, 3];
// PrintArray(array);

// Console.WriteLine();
// for (int j = 0; j < array.GetLength(1); j++)
// {
//     float sum = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum = sum + array[i, j];
//     }

//     float mean = sum / array.GetLength(0);
//     Console.Write(Math.Round(mean, 1) +" ");
// }