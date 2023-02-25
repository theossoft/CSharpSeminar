// Задача 37. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1, 2, 3, 4, 5] -> 5 8 3
// [6, 7, 3, 6] -> 36 21

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

int[] MultiplyFirstAndLastElement(int[] arr)
{
    int size = size = arr.Length / 2;

    if (arr.Length % 2 != 0) size = size + 1;

    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (size % 2 != 0) newArray[size - 1] = arr[size - 1];
    return newArray;
}

int[] randomArray = CreateArrayRandomInt(5, 0, 10);
PrintArray(randomArray);
int[] multiplyFirstAndLastElement = MultiplyFirstAndLastElement(randomArray);
PrintArray(multiplyFirstAndLastElement);