﻿// 23. Напишите программу, которая принимает на вход число (N) 
// и выдает таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int lastNum = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= lastNum; i++) {
    Console.Write(i + "   ");
    Console.WriteLine(i * i * i);
}
