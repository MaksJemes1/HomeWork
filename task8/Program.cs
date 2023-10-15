// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// // 8 -> 2, 4, 6, 8
Console.Clear();
Console.Write("Введите число - ");
int num1 = int.Parse(Console.ReadLine());
int number = 0;
while(number < num1-4)
{
    number = number + 2;
    Console.Write(number + ", ");
}
if(number == num1-4) 
{
    number = number + 2;
    Console.Write(number + ".");
}