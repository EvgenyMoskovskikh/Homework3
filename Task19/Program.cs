﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string array = Console.ReadLine();
if (array[0] == array[4] && array[1] == array[3])
{
Console.Write("Ваше число является палиндромом!");
}
else 
{
    Console.Write("Ваше число не является палиндромом!");
}