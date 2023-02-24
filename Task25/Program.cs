// Задача 25. Напишите цикл, который принимает на вход два числа
// (А и В) и возводит число А в натуральную степень В.
// 3, 5 -> 243
// 2, 4 -> 16

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int pow = Convert.ToInt32(Console.ReadLine());

int exp = Exponentiation(number, pow);
Console.WriteLine($"Число {number} в степени {pow} = {exp}");

int Exponentiation(int a, int b)
{
    int multiple = 1;
    for (int i = 1; i <= b; i++)
    {
        multiple = multiple * a;
    }
    return multiple;
}