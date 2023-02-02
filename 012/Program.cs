// 12 С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
int N, n1, n2;
Console.Write("Введите число щт 10 до 99: ");
N=Convert.ToInt32(System.Console.ReadLine());
n1= N%10;
n2= N/10;
if (n1>n2)
{
    System.Console.WriteLine(n1);
}
else
System.Console.WriteLine(n2);