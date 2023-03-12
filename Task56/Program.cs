// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0 ,  1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(" |");
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int ReturnLineWithMinSumElements(int[,] matrix)
{
    int[] tempArray = new int[matrix.GetLength(0)];
    int minLineIndex = int.MaxValue;
    int minIndex = int.MaxValue;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tempArray[i] = tempArray[i] + matrix[i, j];
        }
    }

    for (int i = 0; i < tempArray.Length; i++)
    {
        if (tempArray[i] < minLineIndex)
        {
            minLineIndex = tempArray[i];
            minIndex = i;
        }
    }
    return minIndex;
}


Console.WriteLine("Вывод случайно сгенерированной матрицы:");
int[,] matrix = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrix);
int index = ReturnLineWithMinSumElements(matrix);
System.Console.WriteLine($"Индекс строки с минимальной суммуй = {index}");

