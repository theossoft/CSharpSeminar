// Задача 30. Напишите программу, которая выводит массив
// из 8 элементов, заполненный  нулями и единицами
// в случайном порядке.
// [1,0,1,1,0,]

int[] NewRandomArray(int num)
{
    Random random = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = random.Next(0,2);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}


PrintArray(NewRandomArray(10));
