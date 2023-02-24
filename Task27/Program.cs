// Задача 27. Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumOfNum(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num%10;
        num = num / 10;
    }
    return sum;
}

int summa = SumOfNum(number);
Console.Write($"Сумма цифр заданного числа = {summa}");