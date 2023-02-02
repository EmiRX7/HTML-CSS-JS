//  7 Выяснить является ли число чётным

int a;
Console.WriteLine("Введите число: ");
a=Convert.ToInt32(System.Console.ReadLine());
if (a % 2==1)
{
    Console.WriteLine("число нечетное");
}
else
{
    Console.WriteLine("Число четное");
}