// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N, которое больше числа M: ");
// int N = Convert.ToInt32(Console.ReadLine());

// if(N >= M)
// {
//     while(N >= M)
//     {
//         Console.Write(M + " ");
//         M++;
//     }
// }

// else
// {
//     Console.Write("Ошибка, N не может быть больше M");
// }



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int sumNumbers = 0;

// if(N >= M)
// {
//     while(N >= M)
//     {
//         sumNumbers += M;
//         M++;
//     }

//     Console.Write($"Cумма натуральных элементов в промежутке от M до N = {sumNumbers}");
// }

// else
// {
//     while(N <= M)
//     {
//         sumNumbers += M;
//         M--;
//     }

//     Console.Write($"Cумма натуральных элементов в промежутке от M до N = {sumNumbers}");
// }



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackerman(int m, int n)
{
    if(m == 0) return n + 1;
    
    else if (n == 0) return Ackerman(m - 1, 1);
    
    else return Ackerman(m - 1, Ackerman(m, n - 1));
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(Ackerman(m, n));