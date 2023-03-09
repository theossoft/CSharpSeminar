// Задача 55. Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести
// сообщение для пользователя.

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

int[,] ReplaceRowsAndColumns(int[,] matrix) // С добавлением массива
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] temp = new int[columns, rows];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            temp[j, i] = matrix[i, j];
        }
    }
    return temp;
}

void ReplaceRowsAndColumnsVoid(int[,] matrix) // Без добавления массива (только квадратная)
{
    for (int i = 0; i < matrix.GetLength(0) - 1; i++) // Добавляя -1 последний элемент не меняется сам с собой
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++) // Добавляя +1 пропускаем первый элемент
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}
int[,] newMatrix = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(newMatrix);
Console.WriteLine("--------------------------");
// PrintMatrix(ReplaceRowsAndColumns(newMatrix));
ReplaceRowsAndColumnsVoid(newMatrix);
PrintMatrix(newMatrix);