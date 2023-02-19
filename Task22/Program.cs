// 22. Напишите программу, которая принимает на вход число (N) и
// выдает таблицу квадратов числел от 1 до N.
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

Console.Write("Введите число: ");
int lastNum = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= lastNum; i++) {
    Console.Write(i + "   ");
    Console.WriteLine(i * i);
}