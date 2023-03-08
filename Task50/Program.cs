// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите позицию в строке: ");
int rowPosition = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию в столбце: ");
int colPosition = Convert.ToInt32(Console.ReadLine());

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

int ReturnNumberFromPositionInMatrix(int[,] matrix, int rowPosition, int collPosition)
{
    if (matrix.GetLength(0) < rowPosition || matrix.GetLength(1) < collPosition) return -1;
    else return matrix[rowPosition, collPosition];
}

int[,] array2D = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2D);
int num = ReturnNumberFromPositionInMatrix(array2D, rowPosition, colPosition);
if (num == -1) Console.WriteLine("Такого элемента нет в массиве.");
else Console.WriteLine($"На позиции {rowPosition}:{colPosition} находится число: {num}");
