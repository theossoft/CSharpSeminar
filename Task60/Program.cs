// Задача 60. ...Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[,,] CreateCubeRndInt(int rows, int columns, int depth, int min, int max, bool isUnique)
{
    int[,,] cube = new int[rows, columns, depth]; // 0, 1, 2
    Random random = new Random();

    int[] arrayUnique = new int[cube.Length];
    int arrayUniqueCount = 0;
    // for (int i = 0; i < arrayUnique.Length; i++)
    // {
    //     int temp = random.Next(min, max + 1);
    //     for (int j = 0; j < arrayUnique.Length; j++)
    //     {
    //         if (arrayUnique[j] != temp)
    //         {
    //             arrayUnique[j] = temp;
    //         }
    //     }        
    // }
    for (int i = 0; i < arrayUnique.Length; ++i)
    {
        bool unique;
        do
        {
            arrayUnique[i] = random.Next(min, max + 1);
            unique = true;
            for (int j = 0; j < i; ++j)
                if (arrayUnique[i] == arrayUnique[j])
                {
                    unique = false;
                    break;
                }
        } while (!unique);
    }

    for (int i = 0; i < cube.GetLength(0); i++) // rows
    {
        for (int j = 0; j < cube.GetLength(1); j++) // columns
        {
            for (int z = 0; z < cube.GetLength(2); z++) // depth
            {
                if (isUnique)
                {
                    cube[i, j, z] = arrayUnique[arrayUniqueCount];
                    arrayUniqueCount++;
                }
                else
                {
                    cube[i, j, z] = random.Next(min, max + 1);
                }

            }
        }
    }
    
    return cube;
}


void PrintCube(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int z = 0; z < cube.GetLength(2); z++)
            {
                Console.Write($"{cube[i, j, z],3} ({i},{j},{z}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Сгенерирован случайным образом куб:");
int[,,] cube = CreateCubeRndInt(4, 4, 4, 10, 99, true);
PrintCube(cube);