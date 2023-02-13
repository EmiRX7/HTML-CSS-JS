// 46 Создать массив из 123 элементов. Заполнить случайными положительными числами от 0 до 1000. Найти количество элементов которые принадлежат отрезку [10,99].

int Math()
{
    int[] Massiv = new int[123];
    Random random;
    random = new Random();
    int counter=0;

    for(int i=0; i<123; i++)
    {
        int a = random.Next(0,1000);
        Massiv[i] = a;
        if(a>9 && a<100)
        {
            counter++;
        }
    }
        foreach (int v in Massiv)
    {
        System.Console.WriteLine($"{v} ");
    }
    System.Console.WriteLine($"Количество чисел принадлежащих [10, 99]: {counter} ");
    return 0;
}

System.Console.WriteLine(Math());