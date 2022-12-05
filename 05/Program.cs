// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел
double a=Convert.ToDouble(Console.ReadLine());
double b=Convert.ToDouble(Console.ReadLine());
double c=Convert.ToDouble(Console.ReadLine());

if (a>b)
    Console.WriteLine($"{a} является больше");
else if (b>c)
    Console.WriteLine($"{b} является больше");
else if (c>a)
    Console.WriteLine($"{c} является больше");
