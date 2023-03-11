// Задача 59. Задайте двумерный массив из целых чисел.
// Напшите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 3 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент равен 1, нвы выходе получим:
// 9 2 3
// 4 2 4
// 2 6 7

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

int[,] PrintMatrixWithoutMinElementColsAndRows(int[,] matrix)
{
    int minNumber = int.MaxValue;
    int indexI = 0;
    int indexJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minNumber)
            {
                minNumber = matrix[i, j];
                indexI = i;
                indexJ = j;
            }
        }
    }
    Console.WriteLine($"Минимальное число в матрице = {minNumber} с индексом [{indexI},{indexJ}]");

    int[,] smallMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int matrixCountI = 0;
    int matrixCountJ = 0;
    for (int i = 0; i < smallMatrix.GetLength(0); i++)
    {
        if (matrixCountI == indexI) matrixCountI++;
        for (int j = 0; j < smallMatrix.GetLength(1); j++)
        {
            if (matrixCountJ == indexJ) matrixCountJ++;
            smallMatrix[i, j] = matrix[matrixCountI, matrixCountJ];
            matrixCountJ++;
        }
        matrixCountI++;
        matrixCountJ = 0;
    }
    return smallMatrix;
}

Console.WriteLine("Вывод случайно сгенерированной матрицы:");
int[,] matrix = CreateMatrixRndInt(6, 6, -100, 100);
PrintMatrix(matrix);
int[,] newMatrix = PrintMatrixWithoutMinElementColsAndRows(matrix);
PrintMatrix(newMatrix);
