// 92 Задайте две матрицы. Напишите программу с подпрограммой MultiMatrix, 
// которая будет находить произведение двух матриц



int MatrixVvod()
{
    Console.WriteLine("Введите матрицу А");
    int[,] MatrixA = new int[3, 3];
    int rowsA = MatrixA.GetUpperBound(0) + 1;
    int columnsA = MatrixA.GetUpperBound(1) + 1;
    for(int i=0; i<rowsA; i++)
    {
        for(int j=0; j<columnsA; j++)
        {
            MatrixA[i,j]=Convert.ToInt32(Console.ReadLine());
        }
    }
    Console.WriteLine("Введите матрицу B");
    int[,] MatrixB = new int[3, 3];
    int rowsB = MatrixB.GetUpperBound(0) + 1;
    int columnsB = MatrixB.GetUpperBound(1) + 1;
    for(int i=0; i<rowsB; i++)
    {
        for(int j=0; j<columnsB; j++)
        {
            MatrixB[i,j]=Convert.ToInt32(Console.ReadLine());
        }
    }
    Console.WriteLine("Матрица A: ");
    for(int i=0; i<rowsA; i++)
    {
        for(int j=0; j<columnsA; j++)
        {
            Console.Write($"{MatrixA[i,j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Матрица B: ");
    for(int i=0; i<rowsB; i++)
    {
        for(int j=0; j<columnsB; j++)
        {
            Console.Write($"{MatrixB[i,j]} \t");
        }
        Console.WriteLine();
    }
    int[,] MatrixC = new int[3,3];
    int chislo = 0;
    for(int i=0; i<rowsA; i++)
    {
        for(int j=0; j<columnsB; j++)
        {
            chislo = 0;
            for(int n=0; n<rowsA; n++)
            {
                chislo += MatrixA[i,n] * MatrixB[n,j];
            }
            MatrixC[i,j] = chislo;
        }
    }
    Console.WriteLine("Матрица C: ");
    for(int i=0; i<rowsA; i++)
    {
        for(int j=0; j<columnsB; j++)
        {
            Console.Write($"{MatrixC[i,j]} \t");
        }
        Console.WriteLine();
    }
    return 0;
}

/*
int MatrixMultiply()
{
    MatrixVvod();
    int[,] MatrixC = new int[3,3];
    int rows = MatrixC.GetUpperBound(0) + 1;
    int columns = MatrixC.GetUpperBound(1) + 1;
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            MatrixC[i,j] = MatrixA[i,j] * MatrixB[i,j];
        }
    }


    return 0;
}
*/
Console.Write(MatrixVvod());