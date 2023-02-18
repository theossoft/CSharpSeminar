// Напишите программу, которая принмает на вход
// два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

Console.Write("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

if (SquareCheck(firstDigit, secondDigit)) Console.WriteLine("Да");
else Console.WriteLine("Нет");

bool SquareCheck(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}