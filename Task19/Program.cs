// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 10000 || x > 99999)
{
    Console.Write("Это не пятизначное число!");
    return;
}

if (Palindrom5Digits(x)) Console.Write("ДА");
else Console.Write("НЕТ");

bool Palindrom5Digits(int number)
{
    if ((number / 10000 == number % 10) && (number / 1000 % 10 == number / 10 % 10)) { return true; }
    return false;
}
