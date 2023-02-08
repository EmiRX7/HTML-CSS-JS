// 36 Написать программу вычисления произведения чисел от 1 до N

int n;
Console.Write("Введите число: ");
n=Convert.ToInt32(System.Console.ReadLine());

int Num()
{
    int prois=1;
    for (int i=1; i<=n;i++)
    {
        prois = prois*i;
    }
    System.Console.WriteLine(prois);
    return 0;
}

System.Console.WriteLine(Num());
