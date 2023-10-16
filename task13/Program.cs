// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.Write("Введите число - ");
int num1 = int.Parse(Console.ReadLine());
int result = num1;
int sum = 0;
if(num1 >= 0 && num1 < 100)
{
   Console.Write("Третьего числа нет!");
}
// else if(num1 > 99 && num1 < 1000)
// {
//    result = num1 % 10;
//    Console.Write("Третьим числом является - " + result);
// } 
while(result > 999)
{
   result = result / 10;
   sum = result;
   Console.WriteLine("Получилось - " + sum);
}
if(sum < 1000)
{
   sum = sum % 10;
Console.WriteLine("Третья цифра - " + sum);
}