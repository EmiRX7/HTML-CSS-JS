// 35 Подсчитать сумму цифр в числе. Сделать подпрограмму.

int n;
Console.Write("Введите число: ");
n=Convert.ToInt32(System.Console.ReadLine());

int Num()
{
    int ost, sum=0;
    do
    {
        ost = n%10;
        sum = sum + ost;
        n/=10;
    }
    while(n!=0);
    System.Console.WriteLine(sum);
    return 0;
}

System.Console.WriteLine(Num());