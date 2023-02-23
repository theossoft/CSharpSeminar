// Задача 28. Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int multiply = Factorial(number);
    Console.Write($"Факториал числа {number} = {multiply}");
}
else
{
    Console.WriteLine("Ошибка ввода - число не натуральное!");
}


int Factorial(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum = sum * i;
        }
    }

    return sum;
}