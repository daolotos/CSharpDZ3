﻿using System;

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < N; i++)
    Console.WriteLine(i * i * i);