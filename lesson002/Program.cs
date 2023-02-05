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
