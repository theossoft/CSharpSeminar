// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            
    else if (N == 0) return (M * (M + 1)) / 2;       
    else if (M == N) return M;                      
    else if (M < N) return N + SumNumbers(M, N - 1); 
    else return N + SumNumbers(M, N + 1);            
}

System.Console.WriteLine(SumNumbers(1,15));
System.Console.WriteLine(SumNumbers(4,8));