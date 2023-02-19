// 20. Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 2D пространстве.
// А(3,6); B(2,1) -> 5,09
// A(7,-5); B(1,-1) -> 7,21

Console.Write("Введите X точки A: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y точки A: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X точки B: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y точки B: ");
int by = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Расстояние между точками А и В: {Math.Round(Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2)),2,MidpointRounding.ToZero)}");