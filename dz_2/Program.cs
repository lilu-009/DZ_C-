// Задача 10

// Console.Write("Enter number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number / 100 >= 1)
// {
//     int number1 = number / 10;
//     int number2 = number1 % 10;

//     Console.Write("Second digit: " +number2);
// }
// else
// {
//     Console.Write("The number is not three digits");
// }



// Задача 13

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number / 100 >= 1)
{
    while(number >= 1000)
    {
        number = number / 10;
    }
    
    int number1 = number % 10;

    Console.Write("Third digit: " +number1);
}
else
{
    Console.Write("No third digit");
}



// Задача 15

// Console.Write("Enter the number of the day of the week: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number <= 7 && number > 0)
// {
//     if(number > 5)
//     {
//         Console.Write("Yes");
//     }

//     else
//     {
//         Console.Write("No");
//     }
// }

// else
// {
//     Console.Write("No such day of the week");
// }



// Задача 14

// Console.Write("Enter number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number % 7 == 0 && number % 23 == 0)
// {
//     Console.Write("Yes");
// }

// else
// {
//     Console.Write("No");
// }