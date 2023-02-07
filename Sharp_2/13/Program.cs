// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. (Цифры считать справа налево).

Console.Clear();
Console.WriteLine("Введите число:");
int a=int.Parse(Console.ReadLine()!);
int a1 = a / 100 %10 ;
a1 = Math.Abs(a1);
if  (a1==0)
{
     Console.WriteLine($"Третьей цифры нет");
}
else
{
     Console.WriteLine($"Третья цифра числа (справа налево) {a} - это {a1}"); 
}

