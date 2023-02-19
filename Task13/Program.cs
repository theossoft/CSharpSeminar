// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите трехзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

if (threeDigitNumber < 100)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    while (threeDigitNumber > 999)
    {
        threeDigitNumber = threeDigitNumber / 10;
    }
    Console.WriteLine($"Третья цифра трехзначного числа {threeDigitNumber} = {threeDigitNumber % 10}");
}
