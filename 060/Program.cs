// 60 Показать двумерный массив размером m×n заполненный случайными числами

int Math()
{
    int[,] Massiv = new int[3, 4];
    Random random;
    random = new Random();

    for(int i=0; i<3; i++)
    {
        for(int p=0; p<4; p++)
        {
        Massiv[i,p] = random.Next(100);
        }
    }
        foreach (int v in Massiv)
    {
        System.Console.WriteLine($"{v} ");
    }
    return 0;
}

System.Console.WriteLine(Math());