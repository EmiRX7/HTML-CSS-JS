// 61 Показать двумерный массив размером m×n заполненный вещественными случайными числами

double Math()
{
    double[,] Massiv = new double[3, 4];
    Random random;
    random = new Random();

    for(int i=0; i<3; i++)
    {
        for(int p=0; p<4; p++)
        {
        Massiv[i,p] = random.NextDouble() * 100;
        }
    }
        foreach (int v in Massiv)
    {
        System.Console.WriteLine($"{v} ");
    }
    return 0;
}

System.Console.WriteLine(Math());