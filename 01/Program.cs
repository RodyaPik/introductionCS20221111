// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// 1. С клавиатуры вводится целое число. Вывести квадрат числа.
int a;
a=10;
Console.Write("Введите число: ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
int b=a*a;
Console.WriteLine(a+"^2="+b);
System.Console.WriteLine("{0}^2={1}",a,b);
System.Console.WriteLine($"{a}^2={b}");
