// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Вторая цифра в трехзначном числе = {(threeDigitNumber % 100) / 10}");

// Пример идеального решения
int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return;
}

int number = Prompt("Введите трехзначное число > ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
    return;
}

Console.WriteLine($"Введенное число `{number}`");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра `{secondRank}`");