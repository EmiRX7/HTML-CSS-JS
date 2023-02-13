// 45 Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] Znach = new int[6];
Random random;
random = new Random();

// Запись рандомный чисел в массив
int Massiv()
{
    for (int i=0; i<6; i++)
    {
        int a = random.Next(100, 999);
        Znach[i]=a;
    }
    foreach (int v in Znach)
    {
        System.Console.WriteLine($"{v} ");
    }
    return 0;
}

// Проверка на четность и подсчет
int Counter()
{
    Massiv();
    int counterNeChet=0, counterChet=0, a;
    for(int i=0; i < Znach.Length; i++)
    {
        a = Znach[i]%2;
        if (a==1)
        {
            counterNeChet++;
        }
        else
        counterChet++;
    }
    Console.WriteLine($"Нечетных чисел: {counterNeChet}");
    Console.WriteLine($"Четных чисел: {counterChet}");
    return 0;
}

Console.WriteLine(Counter());