// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Задача 5");
string wensday = "Среда";
string friday = "Пятница";

int number = Convert.ToInt32(Console.ReadLine());
if (number == 3)
{
    Console.WriteLine(wensday);
}
else if (number == 5)
{
    Console.WriteLine(friday);
}
else
{
    Console.WriteLine("Нет такого дня");
}