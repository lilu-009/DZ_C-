// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] array = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

// void SortingArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for(int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, j] < array[i, k])
//                 {
//                     int temp = array[i, j];
//                     array[i, j] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// SortingArray(array);

// for(int i = 0; i < array.GetLength(0); i++)
// {
//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] array = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7}};

// int sum = int.MaxValue;
// int row = 0;

// for(int i = 0; i < array.GetLength(0); i++)
// {
//     int temp = 0;

//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//         temp = temp + array[i, j];
//     }

//     if(temp < sum)
//     {
//         sum = temp;
//         row = i;
//     }
// }

// Console.Write($"{row + 1} строка с наименьшей суммой элементов {sum}");



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] firstMatrix = {{2, 4}, {3, 2}};
// int[,] secondMatrix = {{3, 4}, {3, 3}};

// if(firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
// {
//     int[,] multMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

//     for(int i = 0; i < firstMatrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < secondMatrix.GetLength(0); j++)
//         {
//             for(int k = 0; k < secondMatrix.GetLength(1); k++)
//             {
//                 multMatrix[i, k] += firstMatrix[i, j] * secondMatrix[j, k];
//             }
//         }
//     }

//     Console.Write("Произведение двух матриц");
//     Console.WriteLine();

//     for(int i = 0; i < firstMatrix.GetLength(0); ++i)
//     {
//         for(int j = 0; j < secondMatrix.GetLength(1); ++j)
//         {
//             Console.Write(multMatrix[i, j] + " ");
//         }

//         Console.WriteLine();
//     }
// }

// else
// {
//     Console.Write("Умножить эти матрицы нельзя");
// }



// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] array = new int[2, 2, 2];

// for(int i = 0; i < 2; i++)
// {
//     for(int j = 0; j < 2; j++)
//     {
//         for(int k = 0; k < 2; k++)
//         {
//             array[i, j, k] = new Random().Next(10, 100);
//             Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//         }
//         Console.WriteLine();  
//     }
// }
