// 9 Вывести на экран четные числа от 1 до N

int N;
Console.Write("Введите число: ");
N=Convert.ToInt32(System.Console.ReadLine());
for (int a = 2; a <= N; a+=2 )
{
    System.Console.WriteLine(a);
}