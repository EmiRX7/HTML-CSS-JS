// Найти сумму цифр числа



int Proga(int n)
{
    if(n < 10)
        return n;
    else
        return n % 10 + Proga(n/10);
}


System.Console.WriteLine("Введите число: ");
int b = Convert.ToInt32(Console.Read());
int sum = Proga(b);
System.Console.WriteLine(Proga(b));
