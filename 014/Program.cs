// 14  С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

int a, b, ost;
Console.Write("Введите два числа в порядке возрастания: ");
a=Convert.ToInt32(System.Console.ReadLine());
b=Convert.ToInt32(System.Console.ReadLine());
ost= a%b;
if (ost==0)
{
    System.Console.WriteLine($"{a} кратно {b}");
}
else
System.Console.WriteLine($"{a} не кратно {b}");
