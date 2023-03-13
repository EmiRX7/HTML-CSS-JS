// Показать натуральные числа от 1 до n

void Proga(int i, int n)
{
    Console.Write($"{i} ");
    n=n+1;
    Console.WriteLine(n);
    i=i-1;
    if (i > 0)
    Proga(i, n);
}

Proga(10, 0);
Console.ReadLine();