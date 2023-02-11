Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

if (number > 0) {count = number * (-1);} else
{
    count = number;
    number = number * (-1);
}

while(count <= number) {
    Console.Write(count + " ");
    count++;
}