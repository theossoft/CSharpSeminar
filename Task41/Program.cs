// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел для ввода: ");
int number = Convert.ToInt32(Console.ReadLine());

int CounPositiveNumber(int num)
{
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        Console.Write("Введите число: ");
        if (Convert.ToInt32(Console.ReadLine()) > 0) count++;
    }
    return count;
}

int a = CounPositiveNumber(number);
Console.WriteLine(a);