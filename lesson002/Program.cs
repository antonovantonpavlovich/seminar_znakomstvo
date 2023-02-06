/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает 
наибольшую цифру числа.

Например
78 -> 8
12 -> 2
85 -> 8

1. получить рандомное число в диапозоне [10, 99]
2. получить максимальную цифру числа
*/
// получить рандомное число в диапозоне [10, 99]
/*
int GetNumber()
{
    Random rnd = new Random();
    int result = rnd.Next(10, 100); // [left, right) -> [10, 100) -> [10, 99]
    return result;
}
// получить максимальную цифру числа
int GetMaxDigitOfNumber(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if (firstDigit > secondDigit)
    return firstDigit;
    else
    return secondDigit;
}

int number = GetNumber();
int maxDigit = GetMaxDigitOfNumber(number);
Console.WriteLine ($"максимальная цифра числа {number} = {maxDigit}");
*/
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////

/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/
/*
Решил сам
int GetNumber()
{
    Random rnd = new Random();
    int result = rnd.Next(100, 1000); // [left, right) -> [100, 1000) -> [100, 999]
    return result;
}
int number = GetNumber();
    int a = number / 100;
    int b = number % 10;

Console.WriteLine ($"{number} -> {a}{b}");
*/
/* решение на уроке
int GetNumber()
{
    Random rnd = new Random();
    int result = rnd.Next(100, 1000); // [left, right) -> [10, 100) -> [10, 99]
    return result;
}
// получить максимальную цифру числа
int GetMaxDigitOfNumber(int number)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;

    return firstDigit * 10 + secondDigit;
}

int number = GetNumber();
int maxDigit = GetMaxDigitOfNumber(number);
Console.WriteLine ($"{number} -> {maxDigit}");
*/
///////////////////////////////////
///////////////////////////////////
///////////////////////////////////
/*
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

/*
int GetNumber(string message)
{
Console.WriteLine(message);
int number = Convert.ToInt32(Console.ReadLine());
return number;
}

int numberA = GetNumber ("Введите первое число");
int numberB = GetNumber ("Введите второе число");

if (numberA % numberB == 0)
{
    Console.WriteLine ($"{numberA}, {numberB} -> кратно");
}
else
{
    Console.WriteLine ($"{numberA}, {numberB} -> не кратно, остаток {numberA % numberB}");
}
*/
///////////////////////////////////
///////////////////////////////////
///////////////////////////////////
/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
7 и 23.

14 -> нет
46 -> нет
161 -> да
*/
/*
int GetNumber(string message)
{
Console.WriteLine(message);
int number = Convert.ToInt32(Console.ReadLine());
return number;
}

int numberA = GetNumber ("Введите число");

if (numberA % 7 == 0 && numberA % 23 == 0)
{
    Console.WriteLine ($"{numberA} -> да");
}
else
Console.WriteLine ($"{numberA} -> нет");
*/
///////////////////////////////////
///////////////////////////////////
///////////////////////////////////
/*
Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/
int GetNumber(string message)
{
Console.WriteLine(message);
int number = Convert.ToInt32(Console.ReadLine());
return number;
}

int numberA = GetNumber ("Введите первое число");
int numberB = GetNumber ("Введите второе число");

if (numberA * numberA == numberB || numberB * numberB == numberA)
{
    Console.WriteLine ($"{numberA}, {numberB} -> да");
}
else
{
    Console.WriteLine ($"{numberA}, {numberB} -> нет");
}