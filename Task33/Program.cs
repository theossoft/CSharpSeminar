// Задача 33. Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// [6, 7, 19, 345, 3] число 4 -> нет
// [6, 7, 19, 345, 3] число 3 -> да

int[] CreateArrayRandomInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

bool IsExists(int num, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;        
    }
    return false;
}

int[] randomArray = CreateArrayRandomInt(10, 0, 10);
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Поиск по рандомному массиву: ");
PrintArray(randomArray);
Console.Write("Есть ли совпадение: ");
if(IsExists(number, randomArray)) Console.WriteLine("Да");
else Console.WriteLine("НЕТ");