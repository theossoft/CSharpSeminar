﻿// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRandomInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int SumEvenNumber(int[] arr) {
    int count = 0;
    for(int i = 0; i < arr.Length; i++) {
        if(arr[i] % 2 == 0) count++;
    }
    return count;
}

int[] randomArray = CreateArrayRandomInt(10, 100, 1000);
PrintArray(randomArray);
int sumEvenNumber = SumEvenNumber(randomArray);
Console.WriteLine($"Количество четных числе в массиве: {sumEvenNumber}");