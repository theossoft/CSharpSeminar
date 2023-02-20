// 21. Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 3D пространстве.
// A(3,6,8); B(2,1,-7) -> 15.84
// A(7,-5,0); B(1,-1,9) -> 11.53

Console.Write("Введите X точки A: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y точки A: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z точки A: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X точки B: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y точки B: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z точки A: ");
int bz = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Расстояние между точками А и В: {Math.Round(Math.Sqrt(Math.Pow((bz - az), 2) + Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2)),2,MidpointRounding.ToZero)}");
