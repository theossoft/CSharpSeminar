// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRandomDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + " ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

double MaxArrayNumber(double[] arr)
{
    double maxNumber = 0;
    for (int i = 0; i < arr.Length; i++)
    {
            if(arr[i] > maxNumber) maxNumber = arr[i];
    }
    return maxNumber;
}

double MinArrayNumber(double[] arr)
{
    double minNumber = double.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
            if(arr[i] < minNumber) minNumber = arr[i];
    }
    return minNumber;
}

double[] randomArray = CreateArrayRandomDouble(10, 0, 10);
PrintArray(randomArray);
Console.WriteLine($"Минимальное значение: {MinArrayNumber(randomArray)}");
Console.WriteLine($"Максимальное значение: {MaxArrayNumber(randomArray)}");
double diff = Math.Round((MaxArrayNumber(randomArray) - MinArrayNumber(randomArray)), 2);
Console.WriteLine($"Разница между максимальным и минимальным значением = {diff}");