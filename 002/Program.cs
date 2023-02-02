// See https://aka.ms/new-console-template for more information
double a, b;
string? s;
s=Console.ReadLine();
a=Convert.ToDouble(s);
b=Convert.ToDouble(Console.ReadLine());

if (a*a==b) 
    System.Console.WriteLine(b + " является квадратом числа " + a);
if (b*b==a)
    System.Console.WriteLine(a + " является квадратом числа " + b);
