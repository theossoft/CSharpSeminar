// Задача 69: Напишите программу, которая на вход принимает два 
// числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число А: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int power = int.Parse(Console.ReadLine());

int APowB(int num, int pow)
{
if(pow == 0) return 1;
else return num * APowB(num, pow-1);
}

System.Console.WriteLine(APowB(number, power));