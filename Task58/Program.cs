// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplyTwoMatrix(int[,] matrixA, int[,] matrixB)
{
    int iMatrixA = 0;
    int jMatrixA = 0;
    int iMatrixB = 0;
    int jMatrixB = 0;

    int[,] multiplyMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < multiplyMatrix.GetLength(0); i++)
    {
        for (int j = 0; multiplyMatrix.GetLength(1); j++)
        {
multiplyMatrix[i,j] = (matrixA[jMatrixA, iMatrixA] * matrixB[iMatrixB, jMatrixB]);
        }
    }
    return multiplyMatrix;
}

System.Console.WriteLine("Сгенерированы две случайные матрицы:");
int[,] matrixA = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrixA);
Console.WriteLine("---------------------");
int[,] matrixB = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrixB);
Console.WriteLine("Произведение двух случайных матриц:");


