// 18. Напишите программу, которая по заданному номеру четверти, показывает
// диапазон возможных координат точе в этой четверти (x и y).

Console.Write("Введите номер четверти 1 - 4: ");
int x = Convert.ToInt32(Console.ReadLine());


string Quarter(int quarter)
{
    if (quarter == 1) return "x > 0 и y > 0";
    if (quarter == 2) return "x < 0 и y > 0";
    if (quarter == 3) return "x < 0 и y < 0";
    if (quarter == 4) return "x > 0 и y < 0";
    return "Четверть должна быть от 1 до 4";
}

Console.WriteLine($"Для четверти {x} интервал = {Quarter(x)}");