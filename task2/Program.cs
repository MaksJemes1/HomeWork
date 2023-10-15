// Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();
Console.Write("Введите первое число - ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
int num2 = int.Parse(Console.ReadLine());

if(num1 > num2)
{
    Console.Write("Число " + num1 + " больше чем " + num2);
}
if(num1 < num2)
{
    Console.Write("Число " + num2 + " больше чем " + num1);
}
if(num1 == num2)
{
    Console.Write("Числа равны. Большего и меньшего нет");
}