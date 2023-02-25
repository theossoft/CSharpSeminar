// Задача 35. Задайте одномерный массив из 123 случайтых чисел.
// Найдите количество элементов массива, значения которых лежат
// в отрезке [10, 99].
// Пример длямассива из 5, а не 123 элементов.
// В своем решении сделайте для 123.
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int CountArrayIn10To99(int[] arr)
{
int count = 0;
for (int i = 0; i < arr.Length; i++) {
    if (arr[i] >= 10 && arr[i] < 100) count++;
}
return count;
}

int[] randomArray = CreateArrayRandomInt(123, -10, 200);
int countArrayIn10To99 = CountArrayIn10To99(randomArray);
// PrintArray(randomArray);
Console.WriteLine("Количество вхождений: " + countArrayIn10To99);
