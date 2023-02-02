// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них. (блок-схема)

int a, b, max;
System.Console.WriteLine("Введите два числа: ");
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    max = a;
    System.Console.WriteLine(max);
}
else
{
    max = b;
    System.Console.WriteLine(max);
}