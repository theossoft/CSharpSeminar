// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удалет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int random = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число из отрезка 100 - 999 => {random}");

int firstDigit = random / 100;
int thirdDigit = random % 10;

Console.WriteLine($"Из случайного трехзначного числа была удалена вторая цийра => {firstDigit}{thirdDigit}");

