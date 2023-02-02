// 5 С клавиатуры вводятся три числа. Найти максимальное из трех чисел

int a, b, c, max;
Console.Write("Введите три числа: ");
a=Convert.ToInt32(System.Console.ReadLine());
b=Convert.ToInt32(System.Console.ReadLine());
c=Convert.ToInt32(System.Console.ReadLine());
if (a>b)
{
    max = a;
    System.Console.WriteLine(max);
}
else
{
    if(b>c)
    {
        max=b;
        System.Console.WriteLine(max);
    }
    else 
    {
        max=c;
        System.Console.WriteLine(max);
    }
    if (a>c)
    System.Console.WriteLine(max);
}