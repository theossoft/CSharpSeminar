// 14. Напишите программу, которая принимает на вход число и
// проверяет, кратно ли оно одновременно 7 и 23.
// 14 нет
// 46 нет 
// 161 нет

Console.Write("Введите число, чтобы проверить кратно ли оно 7 и 23: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(multiple7and23(num));


string multiple7and23 (int number) {
if(number % 7 == 0 && number % 23 == 0)
return "Да";
else return "Нет";
}