// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > arg3) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

Console.Write("Введите первое число - ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число - ");
int num3 = int.Parse(Console.ReadLine());

int max = Max(num1, num2, num3);

Console.Write("Максимальным числом является " + max);