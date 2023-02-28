// Задача 40. Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Введите длину стороны треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны треугольника: ");
int c = Convert.ToInt32(Console.ReadLine());


bool isTreangleExists(int x, int y, int z)
{
    if (a + b > c && b + c > a && c + a > b)
        return true;
    else
        return false;
}


if (isTreangleExists(a, b, c))
    Console.WriteLine("Треугольник существует.");
else
    Console.WriteLine("Треугольник НЕсуществует.");