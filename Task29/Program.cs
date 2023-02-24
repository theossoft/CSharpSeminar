// Задача 29. Напишите программу, которая задаёт массив из 
// 8 элементов и выводит из на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] NewRandom8NumArray(int start, int finish)
{
    Random random = new Random();
    int[] arr = new int[8];
    for (int i = 0; i < 8; i++)
    {
        arr[i] = random.Next(start, finish + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i == arr.Length - 1) Console.Write(arr[i]);
        else Console.Write(arr[i] + ", ");
    }
    Console.Write("]");
}


PrintArray(NewRandom8NumArray(0, 20));