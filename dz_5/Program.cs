// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


// void PrintArray(int[] arr)
// {
//     Console.Write("Массив: ");

//     for(int i= 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(100, 1000);
//         Console.Write(arr[i] +" ");
//     }
// }

// int[] arr = new int[4];
// PrintArray(arr);

// Console.WriteLine();

// int count = 0;

// for(int i= 0; i < arr.Length; i++)
// {
//     if(arr[i] % 2 == 0) count += 1;
// }

// Console.Write("Количество четных чисел = " +count);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// void PrintArray(int[] arr)
// {
//     Console.Write("Массив: ");

//     for(int i= 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 100);
//         Console.Write(arr[i] +" ");
//     }
// }

// int[] arr = new int[7];
// PrintArray(arr);

// Console.WriteLine();

// int sum = 0;

// for(int i= 0; i < arr.Length; i++)
// {
//     if(i % 2 != 0) sum += arr[i];
// }

// Console.Write("Cумма элементов, стоящих на нечётных позициях = " +sum);


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] arr1 = new int[7];

Console.Write("Массив: ");

for (int i = 0; i < arr1.Length; i++)
{
    arr1[i] = new Random().Next(0, 10);
    Console.Write(arr1[i] + " ");
}

Console.WriteLine();

int[] arr2 = new int[4];

Console.Write("Новый массив: ");

for (int i = 0; i < arr2.Length; i++)
{
    if (i < (arr1.Length / 2))
    {
        arr2[i] = arr1[i] * arr1[(arr1.Length - 1) - i];
        Console.Write(arr2[i] + " ");
    }

    else
    {
        arr2[i] = arr1[i];
        Console.Write(arr2[i]);
    }
}



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

// void PrintArray(double[] arr)
// {
//     Console.Write("Массив: ");

//     for(int i= 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 100);
//         Console.Write(arr[i] +" ");
//     }
// }

// double[] arr = new double[7];
// PrintArray(arr);

// Console.WriteLine();

// double maxElement = arr[0];
// double minElement = arr[0];

// for(int i= 0; i < arr.Length; i++)
// {
//     if(arr[i] > maxElement) maxElement = arr[i];
//     else if(arr[i] < minElement) minElement = arr[i];
// }

// double diff = maxElement - minElement;
// Console.Write("Разница между максимальным и минимальным элементом массива = " +diff);