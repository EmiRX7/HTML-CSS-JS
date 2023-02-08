// See https://aka.ms/new-console-template for more information

int n;
Console.Write("Введите число: ");
n=Convert.ToInt32(System.Console.ReadLine());

int PowNum()
{
    int i, a=0;
        for (i=1; i<=n; i++)
    {
        a=a+i;
    }
    System.Console.WriteLine(a);
    return 0;
}

System.Console.WriteLine(PowNum());