// See https://aka.ms/new-console-template for more information





int[,] Massiv = new int[2, 8];
int Proga()
{
    int arr;
    Random random;
    random = new Random();

    for(int i=0; i<2; i++)
    {
        for(int p=1; p<8; p++)
        {
        Massiv[i,p] = random.Next(100);
        }
    }
    foreach (int i in Massiv)
    {
        foreach (int j in Massiv)
            Array.Sort(Massiv);
    }
    return 0;
}
System.Console.WriteLine(Proga());