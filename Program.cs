// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// 10


// int GetSecondDigit (int num) 
// {
//     int result = num / 10;
//     result = result % 10;
//     return result;
// }
// Console.Write("Please input number a = ");
// int number = Convert.ToInt32(Console.ReadLine( ));
// Console.Write($"Second Digit -> { GetSecondDigit (number) } ");



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// int GetThirdDigit (int num)
// {
//     int num1 = num;
//     int count = 0;
//     if (num / 100 == 0) return -1;
//     while (num1 > 0) 
//     {
//         if( num1 / 1000 == 0) return num1 % 10;
//         num1 = num1 / 10;
//         count = count + 1;

//     }
//     return 0;
// }
// Console.Write("Please input number a = ");
// int number = Convert.ToInt32(Console.ReadLine( ));
// if (GetThirdDigit (number) == -1) Console.Write("третьей цифры нет");
// else ($"Second Digit -> { GetThirdDigit (number) } ");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// void IsWeekend ( int num )
// {
//     if ( num > 5 ) Console.WriteLine($"{num} -> да ");
//     else  Console.WriteLine($"{num} -> нет ");
// }
// Console.Write("Please input week day = ");
// int number = Convert.ToInt32(Console.ReadLine( ));
// IsWeekend (number);