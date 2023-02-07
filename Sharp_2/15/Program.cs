//  Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите число:");
int a=int.Parse(Console.ReadLine()!);
if  (a == 6 || a == 7) 
     Console.WriteLine($"{a}-ой день - выходной!");
else if (a>=1 && a<=5) 
{
     Console.WriteLine($"{a}-й будний день =("); 
}
else 
{    
    Console.WriteLine($"В неделе 7 дней!"); 
}