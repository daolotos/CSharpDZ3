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
    left = left / 10;
    right = right * 10;
}

if (isPolyndrom)
    Console.WriteLine("О, да, это полиндром");
else
    Console.WriteLine("Увы, это не полиндром");

