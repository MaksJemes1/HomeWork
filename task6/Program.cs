﻿// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Clear();
Console.Write("Введите число - ");
int num1 = int.Parse(Console.ReadLine());
int result = num1 % 2;
if (result == 0)
{
    Console.Write("Введенное число является четным");
}
else
{
    Console.Write("Введенное число является не четным");
}