// 51 С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

int Math()
{
    int counter = 0;
    System.Console.WriteLine("Введите количество чисел");
    int N = Convert.ToInt32(System.Console.ReadLine());
    int[] Massiv = new int[N];
    System.Console.WriteLine("Введите числа");
    for(int i=0; i<N; i++)
    {
        int a = Convert.ToInt32(System.Console.ReadLine());
        Massiv[i]=a;
    }
    for(int i=0; i<N; i++)
    {
        int a = Massiv[i];
        if (a>0)
        {
            counter++;
        }
    }
    System.Console.WriteLine(counter);
    return 0;
}

System.Console.WriteLine(Math());