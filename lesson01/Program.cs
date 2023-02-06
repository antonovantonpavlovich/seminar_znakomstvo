/*Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

Например:
4 -> 16
-3 -> 9
-7 -> 49*/

/*Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();//124325, ghgjbjbgjk - "с консоли всегда будет приходить строка"
int number = Convert.ToInt32(numberStr);//"42578346" -> 42578346 - из строчки получаем число

int result = number * number; // результат - число умноженное на число
Console.WriteLine($"Квадрат числа {number} = {result}");
Console.WriteLine("Квадрат числа {number} = {result}");
Console.WriteLine("Квадрат числа {0} = {1}", number, result);
Console.WriteLine("Квадрат числа " + number + " = " + result);
*/

/*Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, 
является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет

Console.WriteLine("Введите первое число");
string numberStrA = Console.ReadLine();
int numberA = Convert.ToInt32(numberStrA);
Console.WriteLine("Введите второе число");
string numberStrB = Console.ReadLine();
int numberB = Convert.ToInt32(numberStrB);
int result = numberB * numberB;

if (result == numberA)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
*/

/*Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница*/
/*Console.WriteLine("Введите число от 1 до 7");
string numberStrA = Console.ReadLine();
int numberA = Convert.ToInt32(numberStrA);
if (numberA == 1)
{
    Console.WriteLine("1 -> понедельник");
}
else if (numberA == 2)
{
    Console.WriteLine("2 -> вторник");
}
else if (numberA == 3)
{
    Console.WriteLine("3 -> среда");
}
else if (numberA == 4)
{
    Console.WriteLine("4 -> четверг");
}
else if (numberA == 5)
{
    Console.WriteLine("5 -> пятница");
}
else if (numberA == 6)
{
    Console.WriteLine("6 -> суббота");
}
else if (numberA == 7)
{
    Console.WriteLine("7 -> воскресение");
}
else
{
    Console.WriteLine("Ввели неверное число");
}*/
/*
Задача №5. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/
/*Console.WriteLine("Введите положительное число");
string str = Console.ReadLine();
int a = Convert.ToInt32(str);
int b = -a;
while (b==a)
Console.WriteLine(b);
{
    b = b+1;
    Console.WriteLine(b);
}*/
/*Задача №5. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"*/
/*
Console.WriteLine("Введите положительное число");
int number = Math.Abs(int.Parse(Console.ReadLine()));//перевод строку в число другим методом
// Math.Abs - число всегда будет положительным
for (int i = -number; i <= number; i++)
{
    //Console.WriteLine($"{i} "); // интерполяция
    Console.Write($"{i} ");
}*/
/*Задача №7. Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8*/
/*Console.WriteLine("Введите положительное число");
string? a = Console.ReadLine();

if(a != null)
{
    int number = Math.Abs(int.Parse(a));
    Console.WriteLine (number%10);
}*/
/*var - самостоятельно определяет тип данных*/