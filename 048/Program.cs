// 48 Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. Создайте массив, который является произведением пар чисел в одномерном массиве a. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.Read());
int[] Massiv1 = new int[N/2];
int[] Massiv2 = new int[N/2];


int ProgaChet()
{
    //Заполнение массива
    Random random;
    random =new Random();
    for(int i=0; i < N; i++)
    {
        int a = random.Next(1, 10);
        int b = random.Next(1, 10);
        Massiv1[i] = a;
        Massiv2[i] = b;
    }
    for(int i=0; i<N/2; i++)
    {
        int a=0;
        Massiv1[i] = a;
    }
    return 0;
}

int ProgaNeChet()
{
    Random random;
    random =new Random();
    for(int i=0; i < N; i++)
    {
        int a = random.Next(1, 10);
        Massiv2[i] = a;
    }
    return 0;
}


if (N%2==1)
{
    System.Console.WriteLine(ProgaNeChet());
}
else
{
    System.Console.WriteLine(ProgaChet());
}





