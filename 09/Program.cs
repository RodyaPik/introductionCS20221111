﻿// 9. Вывести на экран четные числа от 1 до N

int n=Convert.ToInt32(Console.ReadLine());
int i=1;
while(i<=n)
{
    System.Console.Write($"{i} ");
    i=i+1;
}
System.Console.WriteLine();
for(int j=1;j<=n;j++)
{
    System.Console.Write($"{j} ");
}