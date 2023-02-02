// 8 Вывести на экран числа от -N до N

int N;
Console.Write("Введите число: ");
N=Convert.ToInt32(System.Console.ReadLine());
for (int a = -N; a <= N; a++)
{
    System.Console.WriteLine(a);
}