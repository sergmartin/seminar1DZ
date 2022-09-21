// Задача №4
Console.Write("Напишите первое число: ");
int n1 = Convert.ToInt16(Console.ReadLine());
Console.Write("Напишите виорое число: ");
int n2 = Convert.ToInt16(Console.ReadLine());
Console.Write("Напишите третие число: ");
int n3 = Convert.ToInt16(Console.ReadLine());

if (n1 > n2 && n1 > n3) Console.Write("первое число самое большое!");
if (n2 > n1 && n2 > n3) Console.Write("Второе число самое большое!");
if (n3 > n1 && n3 > n2) Console.Write("Третье число самое большое!");