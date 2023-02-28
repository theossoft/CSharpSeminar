// Задача 44. Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

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

int[] Fibonacci(int num)
{
    if(num <= 0){
        int[] error = new int[1];
        error[0] = -1;
    }

    int[] fibo = new int[num];

        if (num == 1)
    {
        fibo[0] = 0;        
        return fibo;
    }

    fibo[0] = 0;
    fibo[1] = 1;
    for (int i = 2; i < fibo.Length; i++)
    {
        fibo[i] = fibo[i - 1] + fibo[i - 2];
    }
    return fibo;
}

PrintArray(Fibonacci(number));
