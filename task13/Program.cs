// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.Write("Введите число - ");
int num1 = int.Parse(Console.ReadLine());
int number = 0;
if(num1 > 99)
{
    
Console.Write("Молодец");
}
else
{
Console.Write("Третьей цифры нет");
}