// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.Write("Введите число - ");
int num1 = int.Parse(Console.ReadLine());
if(num1 >= 1 && num1 <= 7)
{
if(num1 == 1) Console.Write("Понедельник. Рабочий день.");

if(num1 == 2)Console.Write("Вторник. Рабочий день");

if(num1 == 3) Console.Write("Среда. Рабочий день");

if(num1 == 4) Console.Write("Четверг. Рабочий день");

if(num1 == 5) Console.Write("Пятница. Рабочий день");

if(num1 == 6) Console.Write("Суббота. Выходной день");

if(num1 == 7) Console.Write("Воскресенье. Выходной день");
}
else
{
Console.Write("В одной неделе 7 дней!");
}