// Задача 32. Напишите программу замена элементов массива:
// положительные элементы замените на соответсвующие
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] ArrayReverse(int[] arr) {
    int[] arrReverse = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arrReverse[i] = arr[i] * -1;
    }
    return arrReverse;
}

int[] randomArray = CreateArrayRandomInt(10, -99, 99);
PrintArray(randomArray);
int[] randomArrayReverse = ArrayReverse(randomArray);
PrintArray(randomArrayReverse);