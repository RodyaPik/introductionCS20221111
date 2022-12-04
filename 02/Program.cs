// С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго
System.Console.WriteLine("Введите число а: ");
double a=Convert.ToDouble(Console.ReadLine());
double b=Convert.ToDouble(Console.ReadLine());
/*
//полное условие
if ()
{
    //true
}
else
{
    //false
}
// не полное условие
if ()
{
    //true
}
*/
if (a*a==b) 
{
    System.Console.WriteLine($"{b} является квадратом {a}");
}
if (b*b==a) 
{   
    System.Console.WriteLine($"{a} является квадратом {b}");
}