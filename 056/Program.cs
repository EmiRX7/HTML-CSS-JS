// 56 Написать программу копирования массива

int Math()
{
    System.Console.WriteLine("Введите количество чисел");
    int N = Convert.ToInt32(System.Console.ReadLine());
    int[] Massiv = new int[N];
    System.Console.WriteLine("Введите числа");
    for(int i=0; i<N; i++)
    {
        int a = Convert.ToInt32(System.Console.ReadLine());
        Massiv[i]=a;
    }
    int[] MassivCop = new int[N];
    for(int i=0; i<N; i++)
    {
        int a = Massiv[i];
        MassivCop[i] = a;
    }
    foreach (int i in MassivCop)
    {
        System.Console.Write($"{i} ");
    }
    return 0;
}

System.Console.WriteLine(Math());