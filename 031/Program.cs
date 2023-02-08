// See https://aka.ms/new-console-template for more information

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
        a=(int)Math.Pow(i,3);
        System.Console.WriteLine(a);
    }
    }
    while(i!=n);
    return 0;
}

System.Console.WriteLine(PowNum());
