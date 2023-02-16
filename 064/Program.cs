// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.

int[,] Massiv = new int [2,6] {{1,2,3,4,5,6},{7,8,9,10,11,12}};
for(int i=0; i<6; i++)
{
    for(int j=1; j<6; j=j+2)
    {
        int a = Massiv[i,j];
        a = (int)Math.Pow(a,2);
        System.Console.WriteLine(a);
    }
}