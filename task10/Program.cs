// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.Write("Введите трехзначное число - ");
int num1 = int.Parse(Console.ReadLine());
int number = 0;
if(num1 > 99 && num1 < 1000)
{
    number = num1 / 10;
    number = number % 10;
    
Console.Write("Средняя циферка это " + number);

}
else
{
Console.Write("Ты глупый? Я же сказал ТРЕХЗНАЧНОЕ! Перезапускай теперь!");
}