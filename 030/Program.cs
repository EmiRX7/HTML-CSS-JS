// 30 Вывести на экран таблицу квадратов чисел от 1 до N
/*
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
*/




Console.Write("Введите число: ");


int PowNum()
{
    int n, a=1;
    n=Convert.ToInt32(System.Console.ReadLine());
    int[] num = new int[n];
    for (int i=0; i<n; i++)
    {
        foreach (int b in num)
        {
            a=(int)Math.Pow(i,2);
            System.Console.WriteLine(num[a]);
        }
    }
    System.Console.WriteLine(num[a]);
    return 1;
}

System.Console.WriteLine(PowNum());
