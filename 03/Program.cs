// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них.
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
if (a<b) 
{
    System.Console.WriteLine($"{b} является больше {a}");
}
if (b<a) 
{   
    System.Console.WriteLine($"{a} является больше {b}");
}