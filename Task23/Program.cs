﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    Console.Write(i * i * i + " ");
}
