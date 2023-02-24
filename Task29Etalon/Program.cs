﻿// Задача 29. Напишите программу, которая задаёт массив из 
// 8 элементов и выводит из на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int Prompt(string message)
{
    System.Console.Write(message); // Выводим приглашение ко вводу
    string readInput = System.Console.ReadLine(); // Выводим значение
    int result = int.Parse(readInput); // Приводим к числу
    return result; // возвращаем результат
}

int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length]; // Объявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); // Заполняем случайными цифрами из диапазона
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, "); // Вывод значения массива
    }
    System.Console.Write($"{array[array.Length - 1]}"); // Вывод значения массива
    System.Console.WriteLine("]");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение, для диапазона случайного числа: ");
int max = Prompt("Конечное значение, для диапазона случайного числа: ");
int[] array = GenerateArray(length, min, max); // Заполняем массив случайными числами
PrintArray(array);