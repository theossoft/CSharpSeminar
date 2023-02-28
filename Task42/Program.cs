// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите десятичное число: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

string ConverDecimalToBinary(int num)
{
    string number = "";
    string newString = "";

    if (num == 0) number = "0";

    while (num > 0)
    {
        if (num % 2 == 0)
        {
            number = number + "0";
            num = num / 2;
        }
        else
        {
            number = number + "1";
            num = num / 2;
        }

    }

    for (int i = 0; i < number.Length; i++)
    {
        newString = newString + number[number.Length - 1 - i];
    }

    return newString;
}

// Вариант покороче
string TransformationNumber(int num)
{
    string newNum = string.Empty;
    while (num != 0)
    {
        newNum = num % 2 + newNum;
        num = num / 2;
    }
    return newNum;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string transformationNumber = TransformationNumber(number);
Console.WriteLine(transformationNumber);

Console.Write(ConverDecimalToBinary(decimalNumber));