using System;

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int left = 10000;
int right = 1;
bool isPolyndrom = true;

for (int i = 0; i < 2; i ++)
{
    int leftDigit = (number / left) % 10;
    int rightDigit = (number / right) % 10;
    if (leftDigit != rightDigit)
    {
        isPolyndrom = false;
        break;
    }
    leftDigit /= 10;
    rightDigit *= 10;
}

if (isPolyndrom)
    Console.WriteLine("Это полиндром");
else
    Console.WriteLine("Это не полиндром");

