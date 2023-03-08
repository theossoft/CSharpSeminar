// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintArray(double[] arr)
{
       for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Столбец {i + 1}: " + arr[i]);        
    }
    
}

double[] AverageColumnMatrix(int[,] matrix)
{
    double[] temp = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++) // rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns
        {
            temp[j] = matrix[i, j] + temp[j];
        }
    }

    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = temp[i] / matrix.GetLength(1);
    }
    return temp;
}

Console.WriteLine("Сгенерирована новая матрица:");
int[,] newMatrix = CreateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(newMatrix);
Console.WriteLine("Среднее арифметическое элементов столбца:");
double[] average = AverageColumnMatrix(newMatrix);
PrintArray(average);