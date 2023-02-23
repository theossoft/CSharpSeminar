// Задача 26. Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int numCount(int num)
{
    int count = 0;
    while (num != 0)
    {
        count++;
        num = num / 10;
        
    }
    return count;
}

Console.WriteLine(numCount(number));