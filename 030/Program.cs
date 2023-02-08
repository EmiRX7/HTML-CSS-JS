// 30 Вывести на экран таблицу квадратов чисел от 1 до N

int n;
Console.Write("Введите число: ");
n=Convert.ToInt32(System.Console.ReadLine());

int PowNum()
{
    int i, a;
    do
    {
        for (i=1; i<n; i++)
    {
        a=(int)Math.Pow(i,2);
        System.Console.WriteLine(a);
    }
    }
    while(i!=n);
    return 0;
}

System.Console.WriteLine(PowNum());







/*
int PowNum()
{
    int n, i, a=1;
    n=Convert.ToInt32(System.Console.ReadLine());
    int[] num = new int[n];
    for (i=1; i<=n; i++)
    {
        num[i] = a;
        a=(int)Math.Pow(i,2);
    }
    System.Console.WriteLine(num[i]);
    return 1;
}

System.Console.WriteLine(PowNum());
*/