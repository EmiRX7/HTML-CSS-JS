// 22 По двум заданным числам проверять является ли одно квадратом другого.

double a, b, c=0;

do
{
    Console.Write("Введите число a: ");
    a = Convert.ToInt32(System.Console.ReadLine());
    Console.Write("Введите число b: ");
    b = Convert.ToInt32(System.Console.ReadLine());
    c = Math.Pow(a, 2);
}
while (c!=b);
Console.Write($"{c} является квадратом числа {a}");