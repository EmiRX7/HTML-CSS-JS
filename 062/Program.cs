// 62 В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]).
// Написать отдельную подпрограмму на вход которой подается массив, а на выходе измененный массив.

int[,] Massiv = new int[2, 8];
int Proga()
{
    Random random;
    random = new Random();

    for(int i=0; i<2; i++)
    {
        for(int p=1; p<8; p++)
        {
        Massiv[i,p] = random.Next(100);
        }
    }
    return 0;
}
int Proga2()
{
    Proga();
    for(int i=0; i<2; i++)
    {
        for(int j=1; j<8; j=j+2)
        {
            int a = Massiv[i,j];
            a = a*(-1);
            System.Console.WriteLine(a);
        }
    }
    return 0;
}
System.Console.WriteLine(Proga2());